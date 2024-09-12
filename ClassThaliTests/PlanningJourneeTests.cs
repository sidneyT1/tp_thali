using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassThali;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassThali.Tests
{
    [TestClass()]
    public class PlanningJourneeTests
    {
        [TestMethod()]
        public void CalculerRecetteTest()
        {
            MiniExcursion me = new MiniExcursion(1, "abc", 20);
            MiniExcursionPlanifiee mep = new MiniExcursionPlanifiee("1", me, DateTime.Parse("12:00"));
            PlanningJournee pla = new PlanningJournee(DateTime.Parse("12:00"));

            Assert.AreEqual(0, pla.CalculerRecette(), "pas de montant");

            me.SetMontantParticipation(50);

            Assert.AreEqual(50, pla.CalculerRecette(), "50");


        }
    }
}