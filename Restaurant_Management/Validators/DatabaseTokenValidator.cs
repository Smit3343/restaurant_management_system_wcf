using Restaurant_Management.interfaces;
using Restaurant_Management.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Restaurant_Management.Validators
{
    public class DatabaseTokenValidator : ITokenValidator
    {
        // Todo: Set this from a web.config appSettting value
        public static double DefaultSecondsUntilTokenExpires = 10800;

        private readonly AppDbContext _context;

        public DatabaseTokenValidator(AppDbContext dbContext)
        {
            _context = dbContext;
        }

        public Token token { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool IsValid(string secureToken)
        {
            var token = _context.Tokens.SingleOrDefault(t=>t.SecureToken==secureToken);
            return token != null && !IsExpired(token);
        }

        public static bool IsExpired(Token token)
        {
            var span = DateTime.Now - token.CreateDate;
            return span.TotalSeconds > DefaultSecondsUntilTokenExpires;
        }
    }
}