using CSV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _591租屋
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<RentalListing> datas = RentalData.GetRentalListings();
            //CSVHelper.Write("D:\\c#_Leo老師\\591租屋\\CSV假資料.csv", datas);
            //### 1. 各行政區租金中位數分析
            //計算每個行政區的租金中位數，並列出中位數高於全市租金中位數的行政區。
            //double taipeiMedianRentalPrice = datas.Select(x => (Double)x.Rent).Median();
            //var result = datas.GroupBy(x => x.LocationDistrict)
            //                  .Select(x =>
            //                  {
            //                      double mediumRentPrice = x.Select(y => (double)y.Rent).Median();
            //                      return new
            //                      {
            //                          LocationDistrict = x.Key,
            //                          MediumRentPrice = mediumRentPrice,
            //                      };
            //                  })
            //                  .Where(x => x.MediumRentPrice > taipeiMedianRentalPrice)
            //                  .ToList();
            //foreach (var a in result)
            //{
            //    Console.WriteLine(a.LocationDistrict + " " + a.MediumRentPrice);
            //}
            //Console.WriteLine("");
            //var temp = datas.GroupBy(x => x.LocationDistrict);


            //### 2. 房型坪效分析
            //找出每個行政區中，每坪租金（租金 / 坪數）最高的前三種房型。

            //var result2 = datas.Select(x =>
            //{
            //    return new
            //    {
            //        LocationDistrict = x.LocationDistrict,
            //        PerSizePingRent = (double)x.Rent / x.SizePing,
            //        RoomType = x.Type,
            //    };
            //}).GroupBy(x => x.LocationDistrict).Select(y =>
            //{
            //    var temp2 = y.OrderByDescending(z => z.PerSizePingRent); //要額外用變數存起來!!!!
            //    return temp2.Take(3);
            //}).ToList();

            //Console.WriteLine("");


            //### 3. 設備完整度與租金關聯
            //統計每個行政區中，擁有全部基本設備（冷氣、洗衣機、冰箱、熱水器、網路）的房源平均租金，與非完整設備房源的平均租金差異。
            //var result3 = datas.Select(x =>
            //{
            //    bool judge = false;
            //    if (x.HasAC && x.HasWasher && x.HasFridge && x.HasWaterHeater && x.HasInternet)
            //    {
            //        judge = true;
            //    }
            //    return new
            //    {
            //        LocationDistrict = x.LocationDistrict,
            //        Rent = x.Rent,
            //        HasAllEquipment = judge,
            //    };
            //}).GroupBy(x => x.LocationDistrict).Select(x =>
            //{
            //    int hasAllEquipmentCount = x.Count(y => y.HasAllEquipment == true);
            //    int nonHasAllEquipmentCount = x.Count(y => y.HasAllEquipment == false);
            //    double averageRentOfHasAllEquip = x.Where(y => y.HasAllEquipment == true).Sum(z => z.Rent) / hasAllEquipmentCount;
            //    double averageRentOfNonHasAllEquip = x.Where(y => y.HasAllEquipment == false).Sum(z => z.Rent) / nonHasAllEquipmentCount;
            //    string largeOne = averageRentOfHasAllEquip > averageRentOfNonHasAllEquip ? "「擁有全部基本設備」" : "「沒擁有全部基本設備」";
            //    string smallOne = largeOne == "「擁有全部基本設備」" ? "「沒擁有全部基本設備」" : "「擁有全部基本設備」";
            //    double gap = Math.Abs(averageRentOfHasAllEquip - averageRentOfNonHasAllEquip);
            //    return new
            //    {
            //        LocationDistrict = x.Key,
            //        HasAllEquipmentCount = hasAllEquipmentCount,
            //        AverageRentOfHasAllEquip = averageRentOfHasAllEquip,
            //        NonHasAllEquipmentCount = nonHasAllEquipmentCount,
            //        AverageRentOfNonHasAllEquip = averageRentOfNonHasAllEquip,
            //        Different = largeOne + "比" + smallOne + "多" + gap.ToString() + "元。",
            //    };
            //});




            //### 4. 樓層偏好分析
            //計算每個行政區中，不同樓層範圍（1 - 3層、4 - 8層、9層以上）的房源數量分布比例。

            //var result4 = datas.Select(x =>
            //{
            //    string floorRange = "";
            //    if (x.Floor < 4)
            //    {
            //        floorRange = "1-3層";
            //    }
            //    else if (x.Floor < 9)
            //    {
            //        floorRange = "4-8層";
            //    }
            //    else
            //    {
            //        floorRange = "9層以上";
            //    }
            //    return new
            //    {
            //        LocationDistrict = x.LocationDistrict,
            //        FloorRange = floorRange,
            //    };
            //}).GroupBy(x => new { x.LocationDistrict }).Select(x =>
            //{
            //    double allDataCount = x.Count();
            //    double firstRangeCount = x.Count(y => y.FloorRange == "1-3層");
            //    double fistRangePercentage = firstRangeCount / allDataCount;
            //    double secondRangeCount = x.Count(y => y.FloorRange == "4-8層");
            //    double secondRangePercentage = secondRangeCount / allDataCount;
            //    double thridRangeCount = x.Count(y => y.FloorRange == "9層以上");
            //    double thridRangePercentage = thridRangeCount / allDataCount;
            //    return new
            //    {
            //        LocationDistrict = x.Key,
            //        FirstRangeCount = firstRangeCount,
            //        FistRangePercentage = fistRangePercentage,
            //        SecondRangeCount = secondRangeCount,
            //        SecondRangePercentage = secondRangePercentage,
            //        ThridRangeCount = thridRangeCount,
            //        ThridRangePercentage = thridRangePercentage,
            //    };

            //});


            //## 市場比較分析

            //### 5. 寵物友善房源溢價分析
            //比較每個行政區中，可養寵物與不可養寵物房源的平均租金差異，並找出差異最大的三個行政區。
            var result5 = datas.GroupBy(x => x.LocationDistrict).Select(x =>
            {
                double petsAllowed = 0;
                if (x.Where(y => y.AllowsPets == true).Count() != 0)
                    petsAllowed = x.Where(y => y.AllowsPets == true).Average(z => z.Rent);
                double petsNotAllowed = 0;
                if (x.Where(y => y.AllowsPets == false).Count() != 0)
                    petsNotAllowed = x.Where(y => y.AllowsPets == false).Average(z => z.Rent);
                double diff = Math.Abs(petsAllowed - petsNotAllowed);
                return new
                {
                    LocationDistrict = x.Key,
                    Diff = diff,
                };
            }).OrderByDescending(y => y.Diff).Take(3).ToList();



            //### 6. 捷運宅租金溢價趨勢
            //分析近捷運與非近捷運房源在各行政區的平均租金溢價百分比。

            var result6 = datas.GroupBy(x => x.LocationDistrict).Select(x =>
            {
                double averageRent = x.Average(z => z.Rent);
                double nearMRTAverageRent = 0;
                if (x.Where(y => y.IsNearMRT == true).Count() != 0)
                    nearMRTAverageRent = x.Where(y => y.IsNearMRT == true).Average(z => z.Rent);
                double notNearMRTAverageRent = 0;
                if (x.Where(y => y.IsNearMRT == false).Count() != 0)
                    notNearMRTAverageRent = x.Where(y => y.IsNearMRT == false).Average(z => z.Rent);
                double diffOnNearMRTAverageRent = (nearMRTAverageRent - averageRent) / averageRent;
                double diffOnNotNearMRTAverageRent = (notNearMRTAverageRent - averageRent) / averageRent;
                return new
                {
                    LocationDistrict = x.Key,
                    AverageRent = averageRent,
                    NearMRTAverageRent = nearMRTAverageRent,
                    DiffOnNearMRTAverageRent = diffOnNearMRTAverageRent,
                    NotNearMRTAverageRent = notNearMRTAverageRent,
                    DiffOnNotNearMRTAverageRent = diffOnNotNearMRTAverageRent,
                };
            });


            //### 7. 新上架房源市場占比
            //計算每個行政區中新上架房源佔該區總房源的比例，並按比例高低排序。

            var result7 = datas.GroupBy(x => x.LocationDistrict).Select(x =>
            {
                double total = x.Count();
                double newPublishCount = x.Count(y => y.IsNewlyListed == true);
                double newPublishPercentage = newPublishCount / total;
                return new
                {
                    LocationDistrict = x.Key,
                    NewPublishPercentage = newPublishPercentage,
                };
            }).OrderByDescending(x => x.NewPublishPercentage).ToList();

            //### 8. 短期租賃市場分析
            //找出各行政區中可短期租賃的房源，並計算這些房源的平均租金與該區整體平均租金的比率。
            var result8 = datas.GroupBy(x => x.LocationDistrict).Select(x =>
            {
                double averageRent = x.Average(y => y.Rent);
                double shortTermAverageRent = 0;
                if (x.Where(y => y.ShortTermRent == true).Count() != 0)
                    shortTermAverageRent = x.Where(y => y.ShortTermRent == true).Average(z => z.Rent);
                return new
                {
                    LocationDistrict = x.Key,
                    AverageRent = averageRent,
                    ShortTermAverageRent = shortTermAverageRent,
                };
            }).ToList();


            //## 特徵關聯分析

            //### 9. 建築類型與租金關聯
            //分析每個行政區中，不同建築類型（公寓、電梯大樓、透天厝）的平均租金差異。
            var result9 = datas.GroupBy(x => x.LocationDistrict).Select(x =>
            {
                double averageRent = x.Average(z => z.Rent);
                double apartmentAverageRentDiff = 0;
                if (x.Where(y => y.BuildingType == "公寓").Count() != 0)
                    apartmentAverageRentDiff = x.Where(y => y.BuildingType == "公寓").Average(z => z.Rent) - averageRent;
                double houseAverageRentDiff = 0;
                if (x.Where(y => y.BuildingType == "透天厝").Count() != 0)
                    houseAverageRentDiff = x.Where(y => y.BuildingType == "透天厝").Average(z => z.Rent) - averageRent;
                double elevatorBuildingAverageRentDiff = 0;
                if (x.Where(y => y.BuildingType == "電梯大樓").Count() != 0)
                    elevatorBuildingAverageRentDiff = x.Where(y => y.BuildingType == "電梯大樓").Average(z => z.Rent) - averageRent;
                return new
                {
                    LocationDistrict = x.Key,
                    AverageRent = averageRent,
                    ApartmentAverageRentDiff = apartmentAverageRentDiff,
                    HouseAverageRentDiff = houseAverageRentDiff,
                    ElevatorBuildingAverageRentDiff = elevatorBuildingAverageRentDiff,
                };
            });


            //### 10. 高價房源特徵分析
            //找出租金高於該行政區平均租金1.5倍以上的房源，統計這些房源中擁有陽台、車位、電梯的比例。
            var result10 = datas.GroupBy(x => x.LocationDistrict).Select(x =>
            {
                double averageRentStandard = x.Average(z => z.Rent) * 1.5;
                var largeStandardItems = x.Where(y => y.Rent > averageRentStandard).ToList();
                double allCount = largeStandardItems.Count();
                double hasConditionsCount = largeStandardItems.Where(y => y.HasBalcony && y.HasParking && y.HasElevator).Count();
                double hasConditionsCountRate = hasConditionsCount == 0 ? 0 : hasConditionsCount / allCount;
                return new
                {
                    LocationDistrict = x.Key,
                    AllCount = allCount,
                    HasConditionsCount = hasConditionsCount,
                    HasConditionsCountRate = hasConditionsCountRate,
                };
            });


            //### 11. 坪數區間市場分析
            //將所有房源按坪數分組（10坪以下、10 - 20坪、20 - 30坪、30坪以上），計算各組的平均租金和房源數量。
            var result11 = datas.Select(x =>
            {
                string sizePingRange = "";
                if (x.SizePing < 10)
                {
                    sizePingRange = "10坪以下";
                }
                else if (x.SizePing < 20)
                {
                    sizePingRange = "10 - 20坪";
                }
                else if (x.SizePing < 30)
                {
                    sizePingRange = "20 - 30坪";
                }
                else
                {
                    sizePingRange = "30坪以上";
                }
                return new
                {
                    LocationDistrict = x.LocationDistrict,
                    SizePingRange = sizePingRange,
                    Rent = x.Rent,
                };
            }).GroupBy(x => new { x.LocationDistrict }).Select(x =>
            {
                double firstRangeCount = x.Count(y => y.SizePingRange == "10坪以下");
                double fistRangeAverageRent = 0;
                if (x.Where(y => y.SizePingRange == "10坪以下").Count() != 0)
                    fistRangeAverageRent = x.Where(y => y.SizePingRange == "10坪以下").Average(y => y.Rent);

                double secondRangeCount = x.Count(y => y.SizePingRange == "10 - 20坪");
                double secondRangeAverageRent = 0;
                if (x.Where(y => y.SizePingRange == "10 - 20坪").Count() != 0)
                    secondRangeAverageRent = x.Where(y => y.SizePingRange == "10 - 20坪").Average(y => y.Rent);

                double thirdRangeCount = x.Count(y => y.SizePingRange == "20 - 30坪");
                double thirdRangeAverageRent = 0;
                if (x.Where(y => y.SizePingRange == "20 - 30坪").Count() != 0)
                    thirdRangeAverageRent = x.Where(y => y.SizePingRange == "20 - 30坪").Average(y => y.Rent);


                double fourthRangeCount = x.Count(y => y.SizePingRange == "30坪以上");
                double fourthRangeAverageRent = 0;
                if (x.Where(y => y.SizePingRange == "30坪以上").Count() != 0)
                    fourthRangeAverageRent = x.Where(y => y.SizePingRange == "30坪以上").Average(y => y.Rent);
                return new
                {
                    LocationDistrict = x.Key,
                    FirstRangeCount = firstRangeCount,
                    FistRangeAverageRent = fistRangeAverageRent,
                    SecondRangeCount = secondRangeCount,
                    SecondRangeAverageRent = secondRangeAverageRent,
                    ThridRangeCount = thirdRangeCount,
                    ThirdRangeAverageRent = thirdRangeAverageRent,
                    FourthRangeCount = fourthRangeCount,
                    FourthRangeAverageRent = fourthRangeAverageRent,
                };
            }).ToList();


            //### 12. 房間數與租金關係
            //分析每個行政區中，不同房間數（1房、2房、3房、4房以上）的平均每房租金（總租金 / 房間數）。

            var result12 = datas.Select(x =>
            {
                string roomsRange = "";
                if (x.Rooms < 4)
                {
                    roomsRange = $"{x.Rooms.ToString()}房";
                }
                else
                {
                    roomsRange = "4房以上";
                }
                return new
                {
                    LocationDistrict = x.LocationDistrict,
                    RoomsRange = roomsRange,
                    Rent = x.Rent,
                };
            }).GroupBy(x => new { x.LocationDistrict, x.RoomsRange }).Select(x =>
            {
                double rangeCount = x.Count();
                double rangeAverageRent = x.Average(y => y.Rent);
                return new
                {
                    Anser = $"{x.Key.LocationDistrict},{x.Key.RoomsRange}=數量:{rangeCount},平均租金:{rangeAverageRent}",
                };
            }).ToList();


            //## 進階交叉分析

            //### 13. 樓層與建築類型交叉分析
            //統計電梯大樓中不同樓層範圍的房源數量，以及公寓中不同樓層範圍的房源數量。
            var result13 = datas.Where(x => x.BuildingType == "公寓" || x.BuildingType == "電梯大樓")
                                .GroupBy(y => new { y.BuildingType, y.Floor })
                                .Select(z =>
                                {
                                    string order = z.Key.BuildingType.ToString() == "公寓" ? "A" : "B";
                                    return new
                                    {
                                        Order = $"{order}{z.Key.Floor}",
                                        Anser = $"{z.Key.BuildingType}，第{z.Key.Floor}層，數量:{z.Count()}",
                                    };
                                }).OrderBy(x => x.Order).ToList();



            //### 14. 設備組合分析
            //找出最常見的設備組合（冷氣、洗衣機、冰箱、熱水器、網路的各種組合），並計算每種組合的平均租金。
            var result14 = datas.Select(x =>
            {
                string combination = "";
                if (x.HasAC)
                    combination += "冷氣、";
                if (x.HasWasher)
                    combination += "洗衣機、";
                if (x.HasFridge)
                    combination += "冰箱、";
                if (x.HasWaterHeater)
                    combination += "熱水器、";
                if (x.HasInternet)
                    combination += "網路、";
                if (combination[combination.Length - 1].Equals('、'))
                {
                    combination = combination.Remove(combination.Length - 1);
                }
                else
                {
                    combination = "都沒有";
                }

                return new
                {
                    Combination = combination,
                    Rent = x.Rent,
                };
            }).GroupBy(x => new { x.Combination })
            .Select(x =>
            {
                return new
                {
                    Combination = x.Key,
                    AverageRent = x.Average(y => y.Rent),
                };
            }).ToList();

            Console.WriteLine("");
            //### 15. 行政區房型分布差異
            //計算每個行政區中各種房型的占比，找出房型分布最特殊的三個行政區。
            var result15 = datas.GroupBy(x => new { x.LocationDistrict })
                                .Select(x =>
                                {
                                    double count = x.Count();
                                    var eachType = x.GroupBy(y => y.Type)
                                                    .Select(y =>
                                                    {
                                                        double percentage = y.Count() / count;
                                                        return new
                                                        {
                                                            LocationDistrict = x.Key.LocationDistrict.ToString(),
                                                            TypeName = y.Key,
                                                            TypeCount = y.Count(),
                                                            Percentage = percentage,
                                                        };
                                                    }).OrderBy(z => z.Percentage).Take(3).ToList();
                                    return new
                                    {
                                        EachType = eachType,
                                    };
                                }).SelectMany(x => x.EachType).ToList();

            //### 16. 租金離群值檢測
            //找出每個行政區中租金超過該區平均租金2個標準差以上的異常高價房源。
            var result16 = datas.GroupBy(x => new { x.LocationDistrict })
                              .SelectMany(y =>
                              {
                                  double averageRent = y.Average(z => z.Rent);
                                  double standardDeviation = y.Select(z => (double)z.Rent).ToList().StandardDeviation();
                                  var temp = y.Where(z => z.Rent >= (averageRent + 2 * standardDeviation)).ToList();
                                  return temp;
                              });


            //## 市場動態分析

            //### 17. 時間與市場活躍度
            //分析新上架房源在各行政區的分布情況，計算各區新上架房源佔該區總房源的比例。
            var result17 = datas.GroupBy(x => new { x.LocationDistrict })
                               .Select(x =>
                               {
                                   double count = x.Count();
                                   double isNewlyListedCount = x.Count(y => y.IsNewlyListed == true);
                                   double nonIsNewlyListedCount = x.Count(y => y.IsNewlyListed == false);
                                   return new
                                   {
                                       LocationDistrict = x.Key,
                                       IsNewlyListedCount = isNewlyListedCount / count,
                                       NonIsNewlyListedCount = nonIsNewlyListedCount / count,
                                   };
                               }).ToList();


            //### 18. 車位價值分析
            //比較每個行政區中有車位與無車位房源的平均租金差異，並計算車位的隱含價值。
            var result18 = datas.GroupBy(x => new { x.LocationDistrict })
                               .Select(x =>
                               {
                                   double hasParkingAverageRent = 0;
                                   if (x.Count(y => y.HasParking == true) != 0)
                                       hasParkingAverageRent = x.Where(y => y.HasParking == true).Average(y => y.Rent);

                                   double nonHasParkingAverageRent = 0;
                                   if (x.Count(y => y.HasParking == false) != 0)
                                       nonHasParkingAverageRent = x.Where(y => y.HasParking == false).Average(y => y.Rent);

                                   string diff = hasParkingAverageRent == 0 ? "無從比較" : $"{hasParkingAverageRent - nonHasParkingAverageRent}";
                                   return new
                                   {
                                       LocationDistrict = x.Key,
                                       Diff = diff,
                                   };
                               }).ToList();


            //### 19. 陽台對租金的影響
            //分析每個行政區中有陽台與無陽台房源的平均租金差異，並找出差異最大的行政區。
            var result19 = datas.GroupBy(x => new { x.LocationDistrict })
                              .Select(x =>
                              {
                                  double hasBalconyAverageRent = 0;
                                  if (x.Count(y => y.HasBalcony == true) != 0)
                                      hasBalconyAverageRent = x.Where(y => y.HasBalcony == true).Average(y => y.Rent);

                                  double nonHasBalconyAverageRent = 0;
                                  if (x.Count(y => y.HasBalcony == false) != 0)
                                      nonHasBalconyAverageRent = x.Where(y => y.HasBalcony == false).Average(y => y.Rent);

                                  double diff = hasBalconyAverageRent == 0 ? 0 : hasBalconyAverageRent - nonHasBalconyAverageRent;
                                  return new
                                  {
                                      LocationDistrict = x.Key,
                                      Diff = diff,
                                  };
                              }).OrderByDescending(x => x.Diff).Take(1).ToList();



            //### 20. 綜合條件最優房源
            //找出每個行政區中同時滿足：近捷運、可養寵物、設備齊全、租金低於該區中位數，且坪數大於該區平均坪數的房源。

            var result20 = datas.GroupBy(x => new { x.LocationDistrict })
                               .Select(x =>
                               {
                                   double medianRent = x.Select(y => (double)y.Rent).Median();
                                   double medianSizePing = x.Select(y => (double)y.SizePing).Median();
                                   var result = x.Where(y => y.Rent < medianRent && y.SizePing > medianSizePing).ToList();
                                   return new
                                   {
                                       LocationDistrict = x.Key,
                                       Result = result,
                                   };
                               }).ToList();
            Console.WriteLine("");
        }
    }
}
