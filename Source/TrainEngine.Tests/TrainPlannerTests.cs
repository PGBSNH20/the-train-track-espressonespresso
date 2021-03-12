using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    }
}
