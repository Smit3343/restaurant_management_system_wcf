using Restaurant_Management.interfaces;
using Restaurant_Management.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Security.Cryptography;
using System.Web;

namespace Restaurant_Management.Validators
{
    public class DatabaseTokenBuilder:ITokenBuilder
    {
        public static int TokenSize = 100;
        private readonly AppDbContext _context;
        public DatabaseTokenBuilder(AppDbContext context)
        {
            _context = context;
        }
        string getToken(User user)
        {
            string secureToken = BuildSecureToken(TokenSize);
            _context.Tokens.Add(new Token
            {
                SecureToken = secureToken,
                User = user,
                CreateDate = DateTime.Now
            });
            _context.SaveChanges();
            return secureToken;
        }

        public string Build(Credentials cred)
        {
            if (!new DatabaseCredentialsValidator(_context).IsValid(cred))
            {
                throw new AuthenticationException();
            }
            var user = _context.Users.SingleOrDefault(x => x.Email.Equals(cred.Email, StringComparison.CurrentCultureIgnoreCase));

            Token token = _context.Tokens.Where<Token>(t => t.UserId == user.Id).FirstOrDefault();
            if(token ==null)
            {
                return getToken(user);
            }
            else if(DatabaseTokenValidator.IsExpired(token))
            {
                _context.Tokens.Remove(token);
                _context.SaveChanges();
                return getToken(user);
            }
            else
            {
                return token.SecureToken;
            }
        }

        private string BuildSecureToken(int length)
        {
            var buffer = new byte[length];
            using (var rngCryptoServiceProvider = new RNGCryptoServiceProvider())
            {
                rngCryptoServiceProvider.GetNonZeroBytes(buffer);
            }
            return Convert.ToBase64String(buffer);
        }
    }
}