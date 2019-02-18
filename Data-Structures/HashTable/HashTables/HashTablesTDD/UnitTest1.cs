using System;
using Xunit;
using HashTables.Classes;


namespace HashTablesTDD
{
    public class UnitTest1
    {
        /// <summary>
        /// Test to Add to HashTable
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        [Theory]
        [InlineData("key", "value")]
        [InlineData("2", "two")]
        [InlineData("three", 33)]
        public void AddKeyValue(string key, object value)
        {
            Hashtables hashTables = new Hashtables();
            hashTables.Add(key, value);

            Assert.Equal(value, hashTables.GetValue(key));
        }

        /// <summary>
        /// Test to get a value back
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        [Theory]
        [InlineData("random", "returningValue")]
        [InlineData("text", true)]
        [InlineData("three", 444)]
        public void GetValue(string key, object value)
        {
            Hashtables hashTables = new Hashtables();
            hashTables.Add(key, value);

            Assert.Equal(value, hashTables.GetValue(key));
        }

        /// <summary>
        /// Test for Null
        /// </summary>
        [Fact]
        public void GetNull()
        {
            Hashtables hashTables = new Hashtables();
            hashTables.Add("abc", "Josie");
            hashTables.Add("Dog", "Woof");
            hashTables.Add("333", "ponies");
            hashTables.Add("moons", "44");

            Assert.Null(hashTables.GetValue("different"));
        }
        [Fact]
        public void GetNull2()
        {
            Hashtables hashTables = new Hashtables();
            hashTables.Add("abc", "Josie");
            hashTables.Add("Dog", "Woof");
            hashTables.Add("333", "ponies");
            hashTables.Add("moons", "44");

            Assert.Null(hashTables.GetValue("two"));
        }
        [Fact]
        public void GetNull3()
        {
            Hashtables hashTables = new Hashtables();
            hashTables.Add("abc", "Josie");
            hashTables.Add("Dog", "Woof");
            hashTables.Add("333", "ponies");
            hashTables.Add("moons", "44");

            Assert.Null(hashTables.GetValue("three"));
        }

        /// <summary>
        /// Test to handle collision and retrieve Value from collisions
        /// </summary>
        [Fact]
        public void GetCollision1()
        {
            Hashtables hashTables = new Hashtables();
            hashTables.Add("abc", "Josie");
            hashTables.Add("cba", 22);
            hashTables.Add("acb", true);

            Assert.Equal("Josie", hashTables.GetValue("abc"));
        }
        [Fact]
        public void GetCollision2()
        {
            Hashtables hashTables = new Hashtables();
            hashTables.Add("abc", "Josie");
            hashTables.Add("cba", 22);
            hashTables.Add("acb", true);

            Assert.Equal(22, hashTables.GetValue("cba"));
        }
        [Fact]
        public void GetCollision3()
        {
            Hashtables hashTables = new Hashtables();
            hashTables.Add("abc", "Josie");
            hashTables.Add("cba", 22);
            hashTables.Add("acb", true);

            Assert.Equal(true, hashTables.GetValue("acb"));
        }

        /// <summary>
        /// Test to get boolean true
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        [Theory]
        [InlineData("random", "returningValue")]
        [InlineData("text", true)]
        [InlineData("three", 444)]
        public void GetTrue(string key, object value)
        {
            Hashtables hashTables = new Hashtables();
            hashTables.Add(key, value);

            Assert.True(hashTables.Contains(key));
        }

        /// <summary>
        /// Test to get boolean FALSE
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        [Fact]
        public void GetFalse1()
        {
            Hashtables hashTables = new Hashtables();
            hashTables.Add("abc", "Josie");
            hashTables.Add("Dog", "Woof");
            hashTables.Add("333", "ponies");
            hashTables.Add("moons", "44");

            Assert.False(hashTables.Contains("one"));
        }
        [Fact]
        public void GetFalse2()
        {
            Hashtables hashTables = new Hashtables();
            hashTables.Add("abc", "Josie");
            hashTables.Add("Dog", "Woof");
            hashTables.Add("333", "ponies");
            hashTables.Add("moons", "44");

            Assert.False(hashTables.Contains("two"));
        }
        [Fact]
        public void GetFalse3()
        {
            Hashtables hashTables = new Hashtables();
            hashTables.Add("abc", "Josie");
            hashTables.Add("Dog", "Woof");
            hashTables.Add("333", "ponies");
            hashTables.Add("moons", "44");

            Assert.False(hashTables.Contains("three"));
        }
    }
}
