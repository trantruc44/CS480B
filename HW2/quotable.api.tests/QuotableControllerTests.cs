using NUnit.Framework;
using quotable.api.Controllers;
using quotable.api.Models;
using quotable.core;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_Get_Success()
        {
            var controller = new quotesController();

            var actual = controller.Get(0);

            Assert.That(actual.Value.ID, Is.EqualTo(0));
            Assert.That(actual.Value.Quote, Is.EqualTo("To be or not to be."));
            Assert.That(actual.Value.Author, Is.EqualTo("William Shakespeare"));

            actual = controller.Get(1);
            Assert.That(actual.Value.ID, Is.EqualTo(1));
            Assert.That(actual.Value.Quote, Is.EqualTo("So many books, so little time."));
            Assert.That(actual.Value.Author, Is.EqualTo("Frank Zappa"));

            actual = controller.Get(3);
            Assert.That(actual.Value.ID, Is.EqualTo(3));
            Assert.That(actual.Value.Quote, Is.EqualTo("If you tell the truth, you don't have to remember anything."));
            Assert.That(actual.Value.Author, Is.EqualTo("Mark Twain"));

            actual = controller.Get(6);
            Assert.That(actual.Value.ID, Is.EqualTo(6));
            Assert.That(actual.Value.Quote, Is.EqualTo("The man who does not read has no advantage over the man who cannot read."));
            Assert.That(actual.Value.Author, Is.EqualTo("Mark Twain"));
        }

        [Test]
        public void Test_Get_Success2()
        {
            var controller = new quotesController();
            var actual = controller.Get();

            Assert.That(actual.Value.Length, Is.EqualTo(7));
            Assert.That(actual.Value.GetValue(0), Is.EqualTo(quotesController.quotesObjects[0]));
            Assert.That(actual.Value.GetValue(3), Is.EqualTo(quotesController.quotesObjects[3]));
            Assert.That(actual.Value.GetValue(5), Is.EqualTo(quotesController.quotesObjects[5]));
            Assert.That(actual.Value, Is.EqualTo(quotesController.quotesObjects));

        }
    }
}