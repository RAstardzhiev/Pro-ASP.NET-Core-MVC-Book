namespace PartyInvates.Models
{
    using System.Collections.Generic;

    public class Repository
    {
        private static List<GuestResponce> responses = new List<GuestResponce>();

        public static IEnumerable<GuestResponce> Responces => responses;

        public static void AddResponse(GuestResponce responce) => responses.Add(responce);
    }
}
