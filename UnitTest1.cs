using game;
using System;
using Xunit;

namespace GameTest
{
    public class UnitTest1
    {
        Game games = Game.generateGame();
        [Fact]
        public void TestHomeVictory()
        { 
            Score gm = games.getScore(46666);
            Assert.True(gm.home > gm.away);
        }
        [Fact]
        public void TestAwayVictory()
        { 
            Score gm = games.getScore(36666);
            Assert.True(gm.home<gm.away);
        }
        [Fact]
        public void TestDraw()
        { 
            Score gm = games.getScore(6666);
            Assert.Equal(gm.home, gm.away);
        }
        [Fact]
        public void TestNoInList()
        { 
            Assert.Throws<Exception>(() =>
            {
                Score gm = games.getScore(51777);
            }
            );
        }
    }
}
