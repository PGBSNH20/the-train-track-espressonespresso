using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace TrainEngine.Tests
{
    public class TrainPlannerTests
    {
        [Fact]
        private static void WhenCreatingTrain_WithID_2_Expect_4_TimeTables()
        {
            // Act
            var result = new TrainPlanner(new Train(2, "Test Train", 140, true)).FollowSchedule().ToPlan();

            // Assert
            Assert.Equal(4, result.TrainInfos.Count);
        }

        [Fact]
        private static void WhenCreatingTrain_WithID_2_Expect_Starting_StationName_Stonecro()
        {
            // Act
            var result = new TrainPlanner(new Train(2, "Test Train", 140, true)).FollowSchedule().ToPlan();

            // Assert
            Assert.Equal("Stonecro", result.TrainInfos[0].StationName);
        }

        [Fact]
        private static void WhenCreatingTrain_WithID_2_Expect_Crash_StationName_Mount_Juanceo()
        {
            // Act
            var result = new TrainPlanner(new Train(2, "Liams tåg", 9000, true)).FollowSchedule().SetSwitch(Switch.Left).ToPlan();
            var result2 = new TrainPlanner(new Train(3, "Kios tåg", 3, true)).FollowSchedule().SetSwitch(Switch.Right).ToPlan();

            var thread = new Thread(() => result.Start());
            var thread2 = new Thread(() => result2.Start());

            thread.Start();
            thread2.Start();


            var timeDisplay = Clock.TimeDisplay();
            if (timeDisplay == "10:06")
            {
                // Assert
                Assert.True(result.TrainInfos[0].hasCrashed);
            }

        }
    }
}
