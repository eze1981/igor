using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Igor.Tests
{
    [TestFixture]
    public class IgorServiceTests
    {
        [Test]
        public void RequestNotepadAction()
        {
            var service = new IgorService();
            var actions = service.GetActionsFor("notepad");


            //actions.Any(a => a.Name.
            Assert.IsTrue(actions.Count() > 0);
        }
    }
}
