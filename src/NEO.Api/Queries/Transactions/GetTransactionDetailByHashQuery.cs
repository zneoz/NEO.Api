﻿using MediatR;
using NEO.Api.Extensions;

namespace NEO.Api.Queries
{
    public class GetTransactionDetailByHashQuery : IRequest<Response>
    {
        public GetTransactionDetailByHashQuery(string hash) 
        {
            Hash = hash;
        }

        public string Hash { get; set; } 
    }
}
