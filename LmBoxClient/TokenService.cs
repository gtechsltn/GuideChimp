﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LmBoxClient.RestController;
using LmBoxClient.Entities;

namespace LmBoxClient
{
    public class TokenService
    {
        /// <summary>
        /// Creates new token for the given token type and token parameters.. See LmBoxAPI JavaDoc for details:
        /// http://lmbox.labs64.com/javadoc/index.html?com/labs64/lmbox/core/service/TokenService.html
        /// </summary>
        public static Token create(Context context, Token newToken)
        {
            lmbox output = LmBoxAPI.request(context, LmBoxAPI.Method.POST, Constants.Token.ENDPOINT_PATH, newToken.ToDictionary());
            return new Token(output.items[0]);
        }

        /// <summary>
        /// Gets token by its number. See LmBoxAPI JavaDoc for details:
        /// http://lmbox.labs64.com/javadoc/index.html?com/labs64/lmbox/core/service/TokenService.html
        /// </summary>
        public static Token get(Context context, String number)
        {
            lmbox output = LmBoxAPI.request(context, LmBoxAPI.Method.GET, Constants.Token.ENDPOINT_PATH + "/" + number, null);
            return new Token(output.items[0]);
        }
    }
}