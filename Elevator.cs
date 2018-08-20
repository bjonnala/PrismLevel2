using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace PrismLevel2
{
    class Elevator
    {
        private bool _isElevator1DoorOpen;
        private bool _isElevator1InUse;

        private bool _isElevator2DoorOpen;
        private bool _isElevator2InUse;


        public Elevator(int elevator)
        {
            if (elevator == 1)
            {
                _isElevator1DoorOpen = false;
                _isElevator1InUse = false;
            }
            else
            {
                _isElevator2DoorOpen = false;
                _isElevator2InUse = false;
            }
        }

        public string Operate(int elevator,string direction,int destinationfloor,Floor[] floors, int currentFloor)
        {
            string status = string.Empty;
            switch (elevator)
            {
                case 1:
                    if (!_isElevator1InUse)
                    {
                        Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();
                        for (int i = 0; i < 60000; i++)
                        {
                            _isElevator1DoorOpen = true;
                        }
                        stopwatch.Stop();
                        if (stopwatch.Elapsed.Seconds > 60)
                        {
                            status = "Elevator 1 open for more than 60 seconds. Please close the door";
                        }
                        
                        _isElevator1DoorOpen = false;
                        if (currentFloor > (floors.Length-1) && !(currentFloor < 0))
                        {
                            status = "Invalid Selection for Elevator 1";
                        }
                        else
                        {
                            if (direction.ToLower() == "up")
                            {
                                if (destinationfloor > currentFloor)
                                {
                                    destinationfloor = currentFloor + (destinationfloor - currentFloor);
                                    if (destinationfloor == floors.Length)
                                    {
                                        floors[(destinationfloor-1)].Elevator1Floornumber = destinationfloor;
                                    }
                                    else
                                    {
                                        floors[destinationfloor].Elevator1Floornumber = destinationfloor;
                                    }
                                    status = "Elevator 1 scheduled on the way to Floor " + destinationfloor;
                                }
                            }
                            else
                            {
                                if (currentFloor < destinationfloor)
                                {
                                    destinationfloor = destinationfloor - currentFloor;
                                    if (destinationfloor == floors.Length)
                                    {
                                        floors[(destinationfloor - 1)].Elevator1Floornumber = destinationfloor;
                                    }
                                    else
                                    {
                                        floors[destinationfloor].Elevator1Floornumber = destinationfloor;
                                    }
                                    status = "Elevator 1 scheduled on the way to Floor " + destinationfloor;
                                }
                            }
                        }
                    }
                    break;
                case 2:
                    if (!_isElevator2InUse)
                    {
                        Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();
                        for (int i = 0; i < 60000; i++)
                        {
                            _isElevator2DoorOpen = true;
                        }
                        stopwatch.Stop();
                        if (stopwatch.Elapsed.Seconds > 60)
                        {
                            status = "Elevator 2 open for more than 60 seconds. Please close the door";
                        }

                        _isElevator2DoorOpen = false;
                        if (currentFloor > (floors.Length - 1) && !(currentFloor < 0))
                        {
                            status = "Invalid Selection for Elevator 2";
                        }
                        else
                        {
                            if (direction.ToLower() == "up")
                            {
                                if (destinationfloor > currentFloor)
                                {
                                    destinationfloor = currentFloor + (destinationfloor - currentFloor);
                                    if (destinationfloor == floors.Length)
                                    {
                                        floors[(destinationfloor - 1)].Elevator2Floornumber = destinationfloor;
                                    }
                                    else
                                    {
                                        floors[destinationfloor].Elevator2Floornumber = destinationfloor;
                                    }
                                    status = "Elevator 2 scheduled on the way to Floor " + destinationfloor;
                                }
                            }
                            else
                            {
                                if (currentFloor < destinationfloor) // direction is down
                                {
                                    destinationfloor = destinationfloor - currentFloor;
                                    if (destinationfloor == floors.Length)
                                    {
                                        floors[(destinationfloor - 1)].Elevator2Floornumber = destinationfloor;
                                    }
                                    else
                                    {
                                        floors[destinationfloor].Elevator2Floornumber = destinationfloor;
                                    }
                                    status = "Elevator 2 scheduled on the way to Floor " + destinationfloor;
                                }
                            }
                        }
                    }
                    break;
                default:
                    break;
            }

            return status;
        }



    }
}
