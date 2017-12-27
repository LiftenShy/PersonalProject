﻿using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using SocialMusic.Authorize.Service.Interfaces;
using SocialMusic.Authorize.Service.Settings;
using SocialMusic.Models.EntityModels.AuthModels;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace SocialMusic.Authorize.Service.Implements
{
    public class JwtTokenService : ITokenService
    {
        private readonly IOptions<AppSettings> _appSettings;

        public JwtTokenService(
            IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings;
        }

        public void Authorize(UserProfile user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Value.Secret);

            List<Claim> claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Name, user.LoginName));
            foreach (var role in user.UserRole.Roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role.Name));
            }

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials
                (
                    new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature
                )
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
        }
    }
}