using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Travel.Models;
using Travel.ViewModel;

namespace Travel.Services
{
    public class TryServices
    {
        private SelabTravelEntities db = new SelabTravelEntities();
        DbSet<Member> memberDB;

        public DbSet<Member> getMember()
        {
            memberDB = db.Member;


            return memberDB;
        }

        public TryViewModel getName()
        {
            var result = db.Member.FirstOrDefault(x => x.name.Equals("Jack"));
            if (result != null)
            {
                return new TryViewModel()
                {
                    Name = result.name
                };
            }
            else
                return null;
        }
    }
}