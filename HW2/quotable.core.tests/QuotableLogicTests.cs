using NUnit.Framework;
using quotable.api.Controllers;
using quotable.api.Models;
using quotable.core;
using System.Collections.Generic;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test()
        {
            // arrange
            var generator = new quotesController();
            int index = 4;
            int expectedID = 4;
            string expectedQuote = "Without music, life would be a mistake.";
            string expectedAuthor = "Friedrich Nietzsche";

            // act
            var actual = generator.Get(index);

            // assert
            Assert.AreEqual(expectedID, actual.Value.ID);
            Assert.AreEqual(expectedQuote, actual.Value.Quote);
            Assert.AreEqual(expectedAuthor, actual.Value.Author);

            // arrange
            index = 6;
            expectedID = 6;
            expectedQuote = "The man who does not read has no advantage over the man who cannot read.";
            expectedAuthor = "Mark Twain";

            // act
            actual = generator.Get(index);

            // assert
            Assert.AreEqual(expectedID, actual.Value.ID);
            Assert.AreEqual(expectedQuote, actual.Value.Quote);
            Assert.AreEqual(expectedAuthor, actual.Value.Author);


            // arrange
            index = 0;
            expectedID = 0;
            expectedQuote = "To be or not to be."; 
            expectedAuthor = "William Shakespeare";

            // act
            actual = generator.Get(index);

            // assert
            Assert.AreEqual(expectedID, actual.Value.ID);
            Assert.AreEqual(expectedQuote, actual.Value.Quote);
            Assert.AreEqual(expectedAuthor, actual.Value.Author);

            // arrange
            index = 5;
            expectedID = 5;
            expectedQuote = "We accept the love we think we deserve.";
            expectedAuthor = "Stephen Chbosky";

            // act
            actual = generator.Get(index);

            // assert
            Assert.AreEqual(expectedID, actual.Value.ID);
            Assert.AreEqual(expectedQuote, actual.Value.Quote);
            Assert.AreEqual(expectedAuthor, actual.Value.Author);

            // arrange
            index = 2;
            expectedID = 2;
            expectedQuote = "Be the change you wish in the world.";
            expectedAuthor = "Mahatma Gandhi";

            // act
            actual = generator.Get(index);

            // assert
            Assert.AreEqual(expectedID, actual.Value.ID);
            Assert.AreEqual(expectedQuote, actual.Value.Quote);
            Assert.AreEqual(expectedAuthor, actual.Value.Author);

        }
    }
}