using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.Client.Static
{
    public static class Endpoints
    {
        private static readonly string Prefix = "api";

        public static readonly string MatchEndPoint = $"{Prefix}/match";
        public static readonly string MembershipEndPoint = $"{Prefix}/membership";
        public static readonly string MessagesEndPoint = $"{Prefix}/messages";
        public static readonly string PaymentEndPoint = $"{Prefix}/payment";
        public static readonly string ProfileEndPoint = $"{Prefix}/profile";
    }
}
