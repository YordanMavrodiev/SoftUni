using RobotService.Core.Contracts;
using RobotService.Models;
using RobotService.Models.Contracts;
using RobotService.Repositories;
using RobotService.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotService.Core
{
    public class Controller : IController
    {
        private SupplementRepository supplements;
        private RobotRepository robots;
        public Controller()
        {
            supplements = new SupplementRepository();
            robots = new RobotRepository();
        }
        public string CreateRobot(string model, string typeName)
        {
            if (typeName == "DomesticAssistant" )
            {
                DomesticAssistant domesticAssistant = new DomesticAssistant(model);
                    robots.AddNew(domesticAssistant);
                    return $"{typeName} {model} is created and added to the RobotRepository.";
                
            }
            else if (typeName == "IndustrialAssistant")
            {
                    IndustrialAssistant industrialAssistant = new IndustrialAssistant(model);
                    robots.AddNew(industrialAssistant);
                    return $"{typeName} {model} is created and added to the RobotRepository.";
            }
            else
            {
                    return $"Robot type {typeName} cannot be created.";
            }



            
        }

        public string CreateSupplement(string typeName)
        {
            if (typeName == "SpecializedArm" )
            {
                SpecializedArm specializedArm = new SpecializedArm();
                supplements.AddNew(specializedArm);
                return $"{typeName} is created and added to the SupplementRepository.";
                
            }
            else if (typeName == "LaserRadar")
            {
                LaserRadar laserRadar = new LaserRadar();
                supplements.AddNew(laserRadar);
                return $"{typeName} is created and added to the SupplementRepository.";
            }
            else return $"{typeName} is not compatible with our robots.";
        }
        public string UpgradeRobot(string model, string supplementTypeName)
        {
            var supp = supplements.Models().FirstOrDefault(a => a.GetType().Name == supplementTypeName);
            var value = supp.InterfaceStandard;
            var correctName = robots.Models().Where(a => !a.InterfaceStandards.Contains(value)&& a.Model == model).ToList();
            
            
            if (correctName.Count == 0)
            {
                return $"All {model} are already upgraded!";
            }
            else 
            {
                correctName[0].InstallSupplement(supp);
                supplements.RemoveByName(supp.GetType().Name);
                return $"{model} is upgraded with {supplementTypeName}.";
                
                
            }
        }

        public string PerformService(string serviceName, int intefaceStandard, int totalPowerNeeded)
        {
            List<IRobot> robots = new List<IRobot>();

            foreach (var currRobot in this.robots.Models())
            {
                if (currRobot.InterfaceStandards.Any(i => i == intefaceStandard))
                    robots.Add(currRobot);
            }

            if (robots.Count == 0)
                return string.Format(OutputMessages.UnableToPerform, intefaceStandard);

            robots = robots.OrderByDescending(r => r.BatteryLevel).ToList();

            int sum = robots.Sum(r => r.BatteryLevel);

            if (sum < totalPowerNeeded)
                return string.Format(OutputMessages.MorePowerNeeded, serviceName, totalPowerNeeded - sum);

            int count = 0;

            foreach (IRobot robot in robots)
            {
                if (robot.BatteryLevel >= totalPowerNeeded)
                {
                    robot.ExecuteService(totalPowerNeeded);
                    count++;
                    break;
                }

                totalPowerNeeded -= robot.BatteryLevel;
                robot.ExecuteService(robot.BatteryLevel);
                count++;
            }

            return string.Format(OutputMessages.PerformedSuccessfully, serviceName, count);


        }
        public string RobotRecovery(string model, int minutes)
        {
            var feed = this.robots.Models().Where(a => a.Model == model ).ToList();
            int fedCount = 0;
            foreach (var robot in feed)
            {
                if (robot.BatteryLevel < robot.BatteryCapacity / 2)
                {
                    robot.Eating(minutes);
                    fedCount++;
                }
            }
            return $"Robots fed: {fedCount}";
        }

        public string Report()
        {
            List<IRobot> robots = this.robots.Models()
                .OrderByDescending(r => r.BatteryLevel)
                .ThenBy(r => r.BatteryCapacity)
                .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var robot in robots)
            {
                sb.AppendLine(robot.ToString());
            }

            return sb.ToString().Trim();
        }


    }
}
