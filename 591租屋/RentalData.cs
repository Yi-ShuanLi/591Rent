using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _591租屋
{

    public class RentalData
    {
        public static List<RentalListing> GetRentalListings()
        {
            return new List<RentalListing>
        {
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "大安區", Type = "獨立套房", Rent = 12000, Rooms = 1, Bathrooms = 1,
                IsNearMRT = true, IsNewlyListed = true, AllowsPets = false, ShortTermRent = false,
                BuildingType = "電梯大樓", SizePing = 8.5, Floor = 5, TotalFloors = 12,
                HasAC = true, HasWasher = true, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = true, HasBalcony = true
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "信義區", Type = "整層住家", Rent = 35000, Rooms = 3, Bathrooms = 2,
                IsNearMRT = true, IsNewlyListed = false, AllowsPets = true, ShortTermRent = false,
                BuildingType = "公寓", SizePing = 28.0, Floor = 3, TotalFloors = 5,
                HasAC = true, HasWasher = true, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = false, HasParking = false, HasElevator = false, HasBalcony = true
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "中山區", Type = "分租套房", Rent = 8000, Rooms = 1, Bathrooms = 1,
                IsNearMRT = true, IsNewlyListed = false, AllowsPets = false, ShortTermRent = true,
                BuildingType = "電梯大樓", SizePing = 6.0, Floor = 7, TotalFloors = 10,
                HasAC = true, HasWasher = false, HasFridge = true, HasWaterHeater = true,
                HasGas = false, HasInternet = true, HasBed = true, HasParking = false, HasElevator = true, HasBalcony = false
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "松山區", Type = "雅房", Rent = 5500, Rooms = 1, Bathrooms = 0,
                IsNearMRT = false, IsNewlyListed = true, AllowsPets = false, ShortTermRent = false,
                BuildingType = "公寓", SizePing = 4.5, Floor = 2, TotalFloors = 4,
                HasAC = true, HasWasher = false, HasFridge = false, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = false, HasBalcony = false
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "中正區", Type = "整層住家", Rent = 28000, Rooms = 2, Bathrooms = 1,
                IsNearMRT = true, IsNewlyListed = false, AllowsPets = true, ShortTermRent = false,
                BuildingType = "電梯大樓", SizePing = 18.0, Floor = 8, TotalFloors = 15,
                HasAC = true, HasWasher = true, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = false, HasParking = true, HasElevator = true, HasBalcony = true
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "內湖區", Type = "獨立套房", Rent = 15000, Rooms = 1, Bathrooms = 1,
                IsNearMRT = false, IsNewlyListed = true, AllowsPets = true, ShortTermRent = false,
                BuildingType = "電梯大樓", SizePing = 10.0, Floor = 6, TotalFloors = 12,
                HasAC = true, HasWasher = true, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = true, HasElevator = true, HasBalcony = true
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "士林區", Type = "整層住家", Rent = 32000, Rooms = 4, Bathrooms = 2,
                IsNearMRT = true, IsNewlyListed = false, AllowsPets = false, ShortTermRent = false,
                BuildingType = "透天厝", SizePing = 35.0, Floor = 1, TotalFloors = 3,
                HasAC = true, HasWasher = true, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = false, HasParking = true, HasElevator = false, HasBalcony = true
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "文山區", Type = "分租套房", Rent = 7500, Rooms = 1, Bathrooms = 1,
                IsNearMRT = false, IsNewlyListed = true, AllowsPets = false, ShortTermRent = false,
                BuildingType = "公寓", SizePing = 5.5, Floor = 4, TotalFloors = 5,
                HasAC = true, HasWasher = false, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = false, HasBalcony = false
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "北投區", Type = "雅房", Rent = 5000, Rooms = 1, Bathrooms = 0,
                IsNearMRT = true, IsNewlyListed = false, AllowsPets = true, ShortTermRent = true,
                BuildingType = "公寓", SizePing = 4.0, Floor = 3, TotalFloors = 4,
                HasAC = false, HasWasher = false, HasFridge = false, HasWaterHeater = true,
                HasGas = true, HasInternet = false, HasBed = true, HasParking = false, HasElevator = false, HasBalcony = false
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "萬華區", Type = "獨立套房", Rent = 9000, Rooms = 1, Bathrooms = 1,
                IsNearMRT = true, IsNewlyListed = true, AllowsPets = false, ShortTermRent = false,
                BuildingType = "公寓", SizePing = 7.0, Floor = 2, TotalFloors = 5,
                HasAC = true, HasWasher = true, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = false, HasBalcony = false
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "大同區", Type = "整層住家", Rent = 25000, Rooms = 2, Bathrooms = 1,
                IsNearMRT = true, IsNewlyListed = false, AllowsPets = true, ShortTermRent = false,
                BuildingType = "公寓", SizePing = 20.0, Floor = 3, TotalFloors = 5,
                HasAC = true, HasWasher = true, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = false, HasParking = false, HasElevator = false, HasBalcony = true
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "南港區", Type = "獨立套房", Rent = 13000, Rooms = 1, Bathrooms = 1,
                IsNearMRT = true, IsNewlyListed = true, AllowsPets = false, ShortTermRent = false,
                BuildingType = "電梯大樓", SizePing = 9.0, Floor = 10, TotalFloors = 15,
                HasAC = true, HasWasher = true, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = true, HasBalcony = true
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "大安區", Type = "整層住家", Rent = 42000, Rooms = 3, Bathrooms = 2,
                IsNearMRT = true, IsNewlyListed = false, AllowsPets = false, ShortTermRent = false,
                BuildingType = "電梯大樓", SizePing = 32.0, Floor = 7, TotalFloors = 12,
                HasAC = true, HasWasher = true, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = false, HasParking = true, HasElevator = true, HasBalcony = true
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "信義區", Type = "分租套房", Rent = 11000, Rooms = 1, Bathrooms = 1,
                IsNearMRT = true, IsNewlyListed = true, AllowsPets = false, ShortTermRent = true,
                BuildingType = "電梯大樓", SizePing = 7.5, Floor = 5, TotalFloors = 8,
                HasAC = true, HasWasher = false, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = true, HasBalcony = false
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "中山區", Type = "雅房", Rent = 6000, Rooms = 1, Bathrooms = 0,
                IsNearMRT = true, IsNewlyListed = false, AllowsPets = false, ShortTermRent = false,
                BuildingType = "公寓", SizePing = 5.0, Floor = 1, TotalFloors = 4,
                HasAC = true, HasWasher = false, HasFridge = false, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = false, HasBalcony = false
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "松山區", Type = "獨立套房", Rent = 14000, Rooms = 1, Bathrooms = 1,
                IsNearMRT = true, IsNewlyListed = true, AllowsPets = true, ShortTermRent = false,
                BuildingType = "電梯大樓", SizePing = 8.0, Floor = 9, TotalFloors = 14,
                HasAC = true, HasWasher = true, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = true, HasBalcony = true
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "中正區", Type = "整層住家", Rent = 38000, Rooms = 3, Bathrooms = 2,
                IsNearMRT = true, IsNewlyListed = false, AllowsPets = true, ShortTermRent = false,
                BuildingType = "電梯大樓", SizePing = 30.0, Floor = 12, TotalFloors = 20,
                HasAC = true, HasWasher = true, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = false, HasParking = true, HasElevator = true, HasBalcony = true
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "內湖區", Type = "分租套房", Rent = 8500, Rooms = 1, Bathrooms = 1,
                IsNearMRT = false, IsNewlyListed = false, AllowsPets = false, ShortTermRent = false,
                BuildingType = "公寓", SizePing = 6.5, Floor = 3, TotalFloors = 6,
                HasAC = true, HasWasher = false, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = false, HasBalcony = false
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "士林區", Type = "雅房", Rent = 5200, Rooms = 1, Bathrooms = 0,
                IsNearMRT = true, IsNewlyListed = true, AllowsPets = false, ShortTermRent = true,
                BuildingType = "公寓", SizePing = 4.2, Floor = 2, TotalFloors = 4,
                HasAC = true, HasWasher = false, HasFridge = false, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = false, HasBalcony = false
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "文山區", Type = "獨立套房", Rent = 9500, Rooms = 1, Bathrooms = 1,
                IsNearMRT = false, IsNewlyListed = false, AllowsPets = true, ShortTermRent = false,
                BuildingType = "公寓", SizePing = 7.8, Floor = 4, TotalFloors = 5,
                HasAC = true, HasWasher = true, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = false, HasBalcony = true
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "北投區", Type = "整層住家", Rent = 22000, Rooms = 2, Bathrooms = 1,
                IsNearMRT = true, IsNewlyListed = true, AllowsPets = false, ShortTermRent = false,
                BuildingType = "公寓", SizePing = 22.0, Floor = 2, TotalFloors = 4,
                HasAC = true, HasWasher = true, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = false, HasParking = false, HasElevator = false, HasBalcony = true
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "萬華區", Type = "分租套房", Rent = 7000, Rooms = 1, Bathrooms = 1,
                IsNearMRT = true, IsNewlyListed = false, AllowsPets = false, ShortTermRent = false,
                BuildingType = "公寓", SizePing = 5.8, Floor = 1, TotalFloors = 5,
                HasAC = true, HasWasher = false, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = false, HasBalcony = false
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "大同區", Type = "雅房", Rent = 4800, Rooms = 1, Bathrooms = 0,
                IsNearMRT = true, IsNewlyListed = true, AllowsPets = false, ShortTermRent = true,
                BuildingType = "公寓", SizePing = 3.8, Floor = 3, TotalFloors = 5,
                HasAC = false, HasWasher = false, HasFridge = false, HasWaterHeater = true,
                HasGas = true, HasInternet = false, HasBed = true, HasParking = false, HasElevator = false, HasBalcony = false
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "南港區", Type = "整層住家", Rent = 30000, Rooms = 2, Bathrooms = 1,
                IsNearMRT = true, IsNewlyListed = false, AllowsPets = true, ShortTermRent = false,
                BuildingType = "電梯大樓", SizePing = 25.0, Floor = 8, TotalFloors = 12,
                HasAC = true, HasWasher = true, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = false, HasParking = true, HasElevator = true, HasBalcony = true
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "大安區", Type = "獨立套房", Rent = 16000, Rooms = 1, Bathrooms = 1,
                IsNearMRT = true, IsNewlyListed = true, AllowsPets = false, ShortTermRent = false,
                BuildingType = "電梯大樓", SizePing = 11.0, Floor = 6, TotalFloors = 10,
                HasAC = true, HasWasher = true, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = true, HasBalcony = true
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "信義區", Type = "整層住家", Rent = 45000, Rooms = 4, Bathrooms = 2,
                IsNearMRT = true, IsNewlyListed = false, AllowsPets = true, ShortTermRent = false,
                BuildingType = "電梯大樓", SizePing = 38.0, Floor = 15, TotalFloors = 20,
                HasAC = true, HasWasher = true, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = false, HasParking = true, HasElevator = true, HasBalcony = true
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "中山區", Type = "分租套房", Rent = 10000, Rooms = 1, Bathrooms = 1,
                IsNearMRT = true, IsNewlyListed = true, AllowsPets = false, ShortTermRent = true,
                BuildingType = "電梯大樓", SizePing = 8.2, Floor = 4, TotalFloors = 8,
                HasAC = true, HasWasher = false, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = true, HasBalcony = false
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "松山區", Type = "雅房", Rent = 5800, Rooms = 1, Bathrooms = 0,
                IsNearMRT = false, IsNewlyListed = false, AllowsPets = true, ShortTermRent = false,
                BuildingType = "公寓", SizePing = 4.8, Floor = 2, TotalFloors = 4,
                HasAC = true, HasWasher = false, HasFridge = false, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = false, HasBalcony = false
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "中正區", Type = "獨立套房", Rent = 13500, Rooms = 1, Bathrooms = 1,
                IsNearMRT = true, IsNewlyListed = true, AllowsPets = false, ShortTermRent = false,
                BuildingType = "電梯大樓", SizePing = 9.5, Floor = 7, TotalFloors = 12,
                HasAC = true, HasWasher = true, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = true, HasBalcony = true
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "內湖區", Type = "整層住家", Rent = 33000, Rooms = 3, Bathrooms = 2,
                IsNearMRT = false, IsNewlyListed = false, AllowsPets = true, ShortTermRent = false,
                BuildingType = "電梯大樓", SizePing = 29.0, Floor = 5, TotalFloors = 10,
                HasAC = true, HasWasher = true, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = false, HasParking = true, HasElevator = true, HasBalcony = true
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "士林區", Type = "分租套房", Rent = 7800, Rooms = 1, Bathrooms = 1,
                IsNearMRT = true, IsNewlyListed = true, AllowsPets = false, ShortTermRent = false,
                BuildingType = "公寓", SizePing = 6.2, Floor = 3, TotalFloors = 5,
                HasAC = true, HasWasher = false, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = false, HasBalcony = false
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "文山區", Type = "雅房", Rent = 5100, Rooms = 1, Bathrooms = 0,
                IsNearMRT = false, IsNewlyListed = false, AllowsPets = false, ShortTermRent = true,
                BuildingType = "公寓", SizePing = 4.1, Floor = 1, TotalFloors = 4,
                HasAC = false, HasWasher = false, HasFridge = false, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = false, HasBalcony = false
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "北投區", Type = "獨立套房", Rent = 11000, Rooms = 1, Bathrooms = 1,
                IsNearMRT = true, IsNewlyListed = true, AllowsPets = true, ShortTermRent = false,
                BuildingType = "公寓", SizePing = 8.8, Floor = 2, TotalFloors = 4,
                HasAC = true, HasWasher = true, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = false, HasBalcony = true
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "萬華區", Type = "整層住家", Rent = 18000, Rooms = 1, Bathrooms = 1,
                IsNearMRT = true, IsNewlyListed = false, AllowsPets = false, ShortTermRent = false,
                BuildingType = "公寓", SizePing = 15.0, Floor = 3, TotalFloors = 5,
                HasAC = true, HasWasher = true, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = false, HasParking = false, HasElevator = false, HasBalcony = true
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "大同區", Type = "分租套房", Rent = 7200, Rooms = 1, Bathrooms = 1,
                IsNearMRT = true, IsNewlyListed = true, AllowsPets = false, ShortTermRent = false,
                BuildingType = "公寓", SizePing = 5.6, Floor = 4, TotalFloors = 5,
                HasAC = true, HasWasher = false, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = false, HasBalcony = false
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "南港區", Type = "雅房", Rent = 5300, Rooms = 1, Bathrooms = 0,
                IsNearMRT = false, IsNewlyListed = false, AllowsPets = true, ShortTermRent = true,
                BuildingType = "公寓", SizePing = 4.3, Floor = 2, TotalFloors = 4,
                HasAC = true, HasWasher = false, HasFridge = false, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = false, HasBalcony = false
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "大安區", Type = "整層住家", Rent = 48000, Rooms = 4, Bathrooms = 2,
                IsNearMRT = true, IsNewlyListed = false, AllowsPets = false, ShortTermRent = false,
                BuildingType = "電梯大樓", SizePing = 40.0, Floor = 10, TotalFloors = 15,
                HasAC = true, HasWasher = true, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = false, HasParking = true, HasElevator = true, HasBalcony = true
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "信義區", Type = "獨立套房", Rent = 17000, Rooms = 1, Bathrooms = 1,
                IsNearMRT = true, IsNewlyListed = true, AllowsPets = true, ShortTermRent = false,
                BuildingType = "電梯大樓", SizePing = 12.0, Floor = 8, TotalFloors = 12,
                HasAC = true, HasWasher = true, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = true, HasBalcony = true
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "中山區", Type = "分租套房", Rent = 9200, Rooms = 1, Bathrooms = 1,
                IsNearMRT = true, IsNewlyListed = false, AllowsPets = false, ShortTermRent = true,
                BuildingType = "電梯大樓", SizePing = 7.2, Floor = 6, TotalFloors = 9,
                HasAC = true, HasWasher = false, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = true, HasBalcony = false
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "松山區", Type = "雅房", Rent = 6200, Rooms = 1, Bathrooms = 0,
                IsNearMRT = true, IsNewlyListed = true, AllowsPets = false, ShortTermRent = false,
                BuildingType = "公寓", SizePing = 5.2, Floor = 1, TotalFloors = 4,
                HasAC = true, HasWasher = false, HasFridge = false, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = false, HasBalcony = false
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "中正區", Type = "整層住家", Rent = 32000, Rooms = 2, Bathrooms = 1,
                IsNearMRT = true, IsNewlyListed = false, AllowsPets = true, ShortTermRent = false,
                BuildingType = "電梯大樓", SizePing = 26.0, Floor = 9, TotalFloors = 14,
                HasAC = true, HasWasher = true, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = false, HasParking = true, HasElevator = true, HasBalcony = true
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "內湖區", Type = "獨立套房", Rent = 12500, Rooms = 1, Bathrooms = 1,
                IsNearMRT = false, IsNewlyListed = true, AllowsPets = false, ShortTermRent = false,
                BuildingType = "電梯大樓", SizePing = 9.2, Floor = 4, TotalFloors = 8,
                HasAC = true, HasWasher = true, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = true, HasBalcony = true
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "士林區", Type = "整層住家", Rent = 28000, Rooms = 3, Bathrooms = 2,
                IsNearMRT = true, IsNewlyListed = false, AllowsPets = true, ShortTermRent = false,
                BuildingType = "透天厝", SizePing = 32.0, Floor = 1, TotalFloors = 3,
                HasAC = true, HasWasher = true, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = false, HasParking = true, HasElevator = false, HasBalcony = true
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "文山區", Type = "分租套房", Rent = 8300, Rooms = 1, Bathrooms = 1,
                IsNearMRT = false, IsNewlyListed = true, AllowsPets = false, ShortTermRent = false,
                BuildingType = "公寓", SizePing = 6.8, Floor = 3, TotalFloors = 5,
                HasAC = true, HasWasher = false, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = false, HasBalcony = false
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "北投區", Type = "雅房", Rent = 4900, Rooms = 1, Bathrooms = 0,
                IsNearMRT = true, IsNewlyListed = false, AllowsPets = false, ShortTermRent = true,
                BuildingType = "公寓", SizePing = 3.9, Floor = 2, TotalFloors = 4,
                HasAC = false, HasWasher = false, HasFridge = false, HasWaterHeater = true,
                HasGas = true, HasInternet = false, HasBed = true, HasParking = false, HasElevator = false, HasBalcony = false
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "萬華區", Type = "獨立套房", Rent = 10500, Rooms = 1, Bathrooms = 1,
                IsNearMRT = true, IsNewlyListed = true, AllowsPets = true, ShortTermRent = false,
                BuildingType = "公寓", SizePing = 8.5, Floor = 2, TotalFloors = 5,
                HasAC = true, HasWasher = true, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = false, HasBalcony = true
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "大同區", Type = "整層住家", Rent = 23000, Rooms = 2, Bathrooms = 1,
                IsNearMRT = true, IsNewlyListed = false, AllowsPets = false, ShortTermRent = false,
                BuildingType = "公寓", SizePing = 21.0, Floor = 4, TotalFloors = 5,
                HasAC = true, HasWasher = true, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = false, HasParking = false, HasElevator = false, HasBalcony = true
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "南港區", Type = "分租套房", Rent = 8800, Rooms = 1, Bathrooms = 1,
                IsNearMRT = true, IsNewlyListed = true, AllowsPets = false, ShortTermRent = false,
                BuildingType = "電梯大樓", SizePing = 7.0, Floor = 5, TotalFloors = 10,
                HasAC = true, HasWasher = false, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = true, HasBalcony = false
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "大安區", Type = "雅房", Rent = 6700, Rooms = 1, Bathrooms = 0,
                IsNearMRT = true, IsNewlyListed = false, AllowsPets = false, ShortTermRent = true,
                BuildingType = "公寓", SizePing = 5.5, Floor = 3, TotalFloors = 5,
                HasAC = true, HasWasher = false, HasFridge = false, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = false, HasBalcony = false
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "信義區", Type = "整層住家", Rent = 52000, Rooms = 4, Bathrooms = 3,
                IsNearMRT = true, IsNewlyListed = false, AllowsPets = true, ShortTermRent = false,
                BuildingType = "電梯大樓", SizePing = 45.0, Floor = 18, TotalFloors = 25,
                HasAC = true, HasWasher = true, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = false, HasParking = true, HasElevator = true, HasBalcony = true
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "中山區", Type = "獨立套房", Rent = 14500, Rooms = 1, Bathrooms = 1,
                IsNearMRT = true, IsNewlyListed = true, AllowsPets = false, ShortTermRent = false,
                BuildingType = "電梯大樓", SizePing = 10.5, Floor = 7, TotalFloors = 11,
                HasAC = true, HasWasher = true, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = true, HasBalcony = true
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "松山區", Type = "分租套房", Rent = 9800, Rooms = 1, Bathrooms = 1,
                IsNearMRT = true, IsNewlyListed = false, AllowsPets = true, ShortTermRent = true,
                BuildingType = "電梯大樓", SizePing = 8.0, Floor = 4, TotalFloors = 7,
                HasAC = true, HasWasher = false, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = true, HasBalcony = false
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "中正區", Type = "雅房", Rent = 5400, Rooms = 1, Bathrooms = 0,
                IsNearMRT = true, IsNewlyListed = true, AllowsPets = false, ShortTermRent = false,
                BuildingType = "公寓", SizePing = 4.6, Floor = 2, TotalFloors = 4,
                HasAC = true, HasWasher = false, HasFridge = false, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = false, HasBalcony = false
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "內湖區", Type = "整層住家", Rent = 36000, Rooms = 3, Bathrooms = 2,
                IsNearMRT = false, IsNewlyListed = false, AllowsPets = true, ShortTermRent = false,
                BuildingType = "電梯大樓", SizePing = 31.0, Floor = 6, TotalFloors = 12,
                HasAC = true, HasWasher = true, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = false, HasParking = true, HasElevator = true, HasBalcony = true
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "士林區", Type = "獨立套房", Rent = 11500, Rooms = 1, Bathrooms = 1,
                IsNearMRT = true, IsNewlyListed = true, AllowsPets = false, ShortTermRent = false,
                BuildingType = "公寓", SizePing = 9.8, Floor = 3, TotalFloors = 5,
                HasAC = true, HasWasher = true, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = false, HasBalcony = true
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "文山區", Type = "分租套房", Rent = 7600, Rooms = 1, Bathrooms = 1,
                IsNearMRT = false, IsNewlyListed = false, AllowsPets = false, ShortTermRent = false,
                BuildingType = "公寓", SizePing = 6.3, Floor = 4, TotalFloors = 5,
                HasAC = true, HasWasher = false, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = false, HasBalcony = false
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "北投區", Type = "雅房", Rent = 4700, Rooms = 1, Bathrooms = 0,
                IsNearMRT = true, IsNewlyListed = true, AllowsPets = true, ShortTermRent = true,
                BuildingType = "公寓", SizePing = 3.7, Floor = 1, TotalFloors = 4,
                HasAC = false, HasWasher = false, HasFridge = false, HasWaterHeater = true,
                HasGas = true, HasInternet = false, HasBed = true, HasParking = false, HasElevator = false, HasBalcony = false
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "萬華區", Type = "整層住家", Rent = 19500, Rooms = 1, Bathrooms = 1,
                IsNearMRT = true, IsNewlyListed = false, AllowsPets = false, ShortTermRent = false,
                BuildingType = "公寓", SizePing = 16.0, Floor = 2, TotalFloors = 5,
                HasAC = true, HasWasher = true, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = false, HasParking = false, HasElevator = false, HasBalcony = true
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "大同區", Type = "獨立套房", Rent = 12800, Rooms = 1, Bathrooms = 1,
                IsNearMRT = true, IsNewlyListed = true, AllowsPets = false, ShortTermRent = false,
                BuildingType = "電梯大樓", SizePing = 9.0, Floor = 5, TotalFloors = 8,
                HasAC = true, HasWasher = true, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = true, HasBalcony = true
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "南港區", Type = "分租套房", Rent = 8100, Rooms = 1, Bathrooms = 1,
                IsNearMRT = true, IsNewlyListed = false, AllowsPets = false, ShortTermRent = true,
                BuildingType = "公寓", SizePing = 6.5, Floor = 3, TotalFloors = 5,
                HasAC = true, HasWasher = false, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = false, HasBalcony = false
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "大安區", Type = "雅房", Rent = 7100, Rooms = 1, Bathrooms = 0,
                IsNearMRT = true, IsNewlyListed = true, AllowsPets = false, ShortTermRent = false,
                BuildingType = "公寓", SizePing = 5.8, Floor = 4, TotalFloors = 5,
                HasAC = true, HasWasher = false, HasFridge = false, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = false, HasBalcony = false
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "信義區", Type = "整層住家", Rent = 58000, Rooms = 5, Bathrooms = 3,
                IsNearMRT = true, IsNewlyListed = false, AllowsPets = true, ShortTermRent = false,
                BuildingType = "電梯大樓", SizePing = 50.0, Floor = 20, TotalFloors = 25,
                HasAC = true, HasWasher = true, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = false, HasParking = true, HasElevator = true, HasBalcony = true
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "中山區", Type = "獨立套房", Rent = 15500, Rooms = 1, Bathrooms = 1,
                IsNearMRT = true, IsNewlyListed = true, AllowsPets = true, ShortTermRent = false,
                BuildingType = "電梯大樓", SizePing = 11.5, Floor = 9, TotalFloors = 13,
                HasAC = true, HasWasher = true, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = true, HasBalcony = true
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "松山區", Type = "分租套房", Rent = 10500, Rooms = 1, Bathrooms = 1,
                IsNearMRT = true, IsNewlyListed = false, AllowsPets = false, ShortTermRent = true,
                BuildingType = "電梯大樓", SizePing = 8.5, Floor = 5, TotalFloors = 8,
                HasAC = true, HasWasher = false, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = true, HasBalcony = false
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "中正區", Type = "雅房", Rent = 5900, Rooms = 1, Bathrooms = 0,
                IsNearMRT = true, IsNewlyListed = true, AllowsPets = false, ShortTermRent = false,
                BuildingType = "公寓", SizePing = 4.9, Floor = 2, TotalFloors = 4,
                HasAC = true, HasWasher = false, HasFridge = false, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = false, HasBalcony = false
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "內湖區", Type = "整層住家", Rent = 40000, Rooms = 4, Bathrooms = 2,
                IsNearMRT = false, IsNewlyListed = false, AllowsPets = true, ShortTermRent = false,
                BuildingType = "電梯大樓", SizePing = 35.0, Floor = 7, TotalFloors = 12,
                HasAC = true, HasWasher = true, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = false, HasParking = true, HasElevator = true, HasBalcony = true
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "士林區", Type = "獨立套房", Rent = 13500, Rooms = 1, Bathrooms = 1,
                IsNearMRT = true, IsNewlyListed = true, AllowsPets = false, ShortTermRent = false,
                BuildingType = "公寓", SizePing = 10.2, Floor = 4, TotalFloors = 5,
                HasAC = true, HasWasher = true, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = false, HasBalcony = true
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "文山區", Type = "分租套房", Rent = 7900, Rooms = 1, Bathrooms = 1,
                IsNearMRT = false, IsNewlyListed = false, AllowsPets = true, ShortTermRent = false,
                BuildingType = "公寓", SizePing = 6.0, Floor = 3, TotalFloors = 5,
                HasAC = true, HasWasher = false, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = false, HasBalcony = false
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "北投區", Type = "雅房", Rent = 4600, Rooms = 1, Bathrooms = 0,
                IsNearMRT = true, IsNewlyListed = true, AllowsPets = false, ShortTermRent = true,
                BuildingType = "公寓", SizePing = 3.5, Floor = 1, TotalFloors = 4,
                HasAC = false, HasWasher = false, HasFridge = false, HasWaterHeater = true,
                HasGas = true, HasInternet = false, HasBed = true, HasParking = false, HasElevator = false, HasBalcony = false
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "萬華區", Type = "整層住家", Rent = 21000, Rooms = 2, Bathrooms = 1,
                IsNearMRT = true, IsNewlyListed = false, AllowsPets = false, ShortTermRent = false,
                BuildingType = "公寓", SizePing = 18.0, Floor = 3, TotalFloors = 5,
                HasAC = true, HasWasher = true, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = false, HasParking = false, HasElevator = false, HasBalcony = true
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "大同區", Type = "獨立套房", Rent = 14200, Rooms = 1, Bathrooms = 1,
                IsNearMRT = true, IsNewlyListed = true, AllowsPets = true, ShortTermRent = false,
                BuildingType = "電梯大樓", SizePing = 10.8, Floor = 6, TotalFloors = 10,
                HasAC = true, HasWasher = true, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = true, HasBalcony = true
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "南港區", Type = "分租套房", Rent = 8700, Rooms = 1, Bathrooms = 1,
                IsNearMRT = true, IsNewlyListed = false, AllowsPets = false, ShortTermRent = true,
                BuildingType = "公寓", SizePing = 6.7, Floor = 4, TotalFloors = 5,
                HasAC = true, HasWasher = false, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = false, HasBalcony = false
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "大安區", Type = "雅房", Rent = 6800, Rooms = 1, Bathrooms = 0,
                IsNearMRT = true, IsNewlyListed = true, AllowsPets = false, ShortTermRent = false,
                BuildingType = "公寓", SizePing = 5.3, Floor = 3, TotalFloors = 5,
                HasAC = true, HasWasher = false, HasFridge = false, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = false, HasBalcony = false
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "信義區", Type = "整層住家", Rent = 62000, Rooms = 5, Bathrooms = 3,
                IsNearMRT = true, IsNewlyListed = false, AllowsPets = true, ShortTermRent = false,
                BuildingType = "電梯大樓", SizePing = 55.0, Floor = 22, TotalFloors = 28,
                HasAC = true, HasWasher = true, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = false, HasParking = true, HasElevator = true, HasBalcony = true
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "中山區", Type = "獨立套房", Rent = 16500, Rooms = 1, Bathrooms = 1,
                IsNearMRT = true, IsNewlyListed = true, AllowsPets = false, ShortTermRent = false,
                BuildingType = "電梯大樓", SizePing = 12.5, Floor = 10, TotalFloors = 15,
                HasAC = true, HasWasher = true, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = true, HasBalcony = true
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "松山區", Type = "分租套房", Rent = 11200, Rooms = 1, Bathrooms = 1,
                IsNearMRT = true, IsNewlyListed = false, AllowsPets = true, ShortTermRent = true,
                BuildingType = "電梯大樓", SizePing = 9.0, Floor = 6, TotalFloors = 9,
                HasAC = true, HasWasher = false, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = true, HasBalcony = false
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "中正區", Type = "雅房", Rent = 6100, Rooms = 1, Bathrooms = 0,
                IsNearMRT = true, IsNewlyListed = true, AllowsPets = false, ShortTermRent = false,
                BuildingType = "公寓", SizePing = 5.0, Floor = 2, TotalFloors = 4,
                HasAC = true, HasWasher = false, HasFridge = false, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = false, HasBalcony = false
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "內湖區", Type = "整層住家", Rent = 44000, Rooms = 4, Bathrooms = 2,
                IsNearMRT = false, IsNewlyListed = false, AllowsPets = true, ShortTermRent = false,
                BuildingType = "電梯大樓", SizePing = 38.0, Floor = 8, TotalFloors = 14,
                HasAC = true, HasWasher = true, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = false, HasParking = true, HasElevator = true, HasBalcony = true
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "士林區", Type = "獨立套房", Rent = 14800, Rooms = 1, Bathrooms = 1,
                IsNearMRT = true, IsNewlyListed = true, AllowsPets = false, ShortTermRent = false,
                BuildingType = "公寓", SizePing = 11.2, Floor = 5, TotalFloors = 5,
                HasAC = true, HasWasher = true, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = false, HasBalcony = true
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "文山區", Type = "分租套房", Rent = 8200, Rooms = 1, Bathrooms = 1,
                IsNearMRT = false, IsNewlyListed = false, AllowsPets = false, ShortTermRent = false,
                BuildingType = "公寓", SizePing = 6.2, Floor = 4, TotalFloors = 5,
                HasAC = true, HasWasher = false, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = false, HasBalcony = false
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "北投區", Type = "雅房", Rent = 4500, Rooms = 1, Bathrooms = 0,
                IsNearMRT = true, IsNewlyListed = true, AllowsPets = true, ShortTermRent = true,
                BuildingType = "公寓", SizePing = 3.3, Floor = 1, TotalFloors = 4,
                HasAC = false, HasWasher = false, HasFridge = false, HasWaterHeater = true,
                HasGas = true, HasInternet = false, HasBed = true, HasParking = false, HasElevator = false, HasBalcony = false
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "萬華區", Type = "整層住家", Rent = 24000, Rooms = 2, Bathrooms = 1,
                IsNearMRT = true, IsNewlyListed = false, AllowsPets = false, ShortTermRent = false,
                BuildingType = "公寓", SizePing = 19.0, Floor = 3, TotalFloors = 5,
                HasAC = true, HasWasher = true, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = false, HasParking = false, HasElevator = false, HasBalcony = true
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "大同區", Type = "獨立套房", Rent = 13800, Rooms = 1, Bathrooms = 1,
                IsNearMRT = true, IsNewlyListed = true, AllowsPets = false, ShortTermRent = false,
                BuildingType = "電梯大樓", SizePing = 10.0, Floor = 7, TotalFloors = 12,
                HasAC = true, HasWasher = true, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = true, HasBalcony = true
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "南港區", Type = "分租套房", Rent = 9000, Rooms = 1, Bathrooms = 1,
                IsNearMRT = true, IsNewlyListed = false, AllowsPets = false, ShortTermRent = true,
                BuildingType = "公寓", SizePing = 7.3, Floor = 3, TotalFloors = 5,
                HasAC = true, HasWasher = false, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = false, HasBalcony = false
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "大安區", Type = "雅房", Rent = 6900, Rooms = 1, Bathrooms = 0,
                IsNearMRT = true, IsNewlyListed = true, AllowsPets = false, ShortTermRent = false,
                BuildingType = "公寓", SizePing = 5.6, Floor = 4, TotalFloors = 5,
                HasAC = true, HasWasher = false, HasFridge = false, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = false, HasBalcony = false
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "信義區", Type = "整層住家", Rent = 68000, Rooms = 5, Bathrooms = 3,
                IsNearMRT = true, IsNewlyListed = false, AllowsPets = true, ShortTermRent = false,
                BuildingType = "電梯大樓", SizePing = 60.0, Floor = 25, TotalFloors = 30,
                HasAC = true, HasWasher = true, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = false, HasParking = true, HasElevator = true, HasBalcony = true
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "中山區", Type = "獨立套房", Rent = 17200, Rooms = 1, Bathrooms = 1,
                IsNearMRT = true, IsNewlyListed = true, AllowsPets = true, ShortTermRent = false,
                BuildingType = "電梯大樓", SizePing = 13.0, Floor = 11, TotalFloors = 16,
                HasAC = true, HasWasher = true, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = true, HasBalcony = true
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "松山區", Type = "分租套房", Rent = 11800, Rooms = 1, Bathrooms = 1,
                IsNearMRT = true, IsNewlyListed = false, AllowsPets = false, ShortTermRent = true,
                BuildingType = "電梯大樓", SizePing = 9.5, Floor = 7, TotalFloors = 10,
                HasAC = true, HasWasher = false, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = true, HasBalcony = false
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "中正區", Type = "雅房", Rent = 6300, Rooms = 1, Bathrooms = 0,
                IsNearMRT = true, IsNewlyListed = true, AllowsPets = false, ShortTermRent = false,
                BuildingType = "公寓", SizePing = 5.1, Floor = 2, TotalFloors = 4,
                HasAC = true, HasWasher = false, HasFridge = false, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = false, HasBalcony = false
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "內湖區", Type = "整層住家", Rent = 48000, Rooms = 4, Bathrooms = 2,
                IsNearMRT = false, IsNewlyListed = false, AllowsPets = true, ShortTermRent = false,
                BuildingType = "電梯大樓", SizePing = 42.0, Floor = 9, TotalFloors = 15,
                HasAC = true, HasWasher = true, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = false, HasParking = true, HasElevator = true, HasBalcony = true
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "士林區", Type = "獨立套房", Rent = 15800, Rooms = 1, Bathrooms = 1,
                IsNearMRT = true, IsNewlyListed = true, AllowsPets = false, ShortTermRent = false,
                BuildingType = "公寓", SizePing = 12.0, Floor = 4, TotalFloors = 5,
                HasAC = true, HasWasher = true, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = false, HasBalcony = true
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "文山區", Type = "分租套房", Rent = 8400, Rooms = 1, Bathrooms = 1,
                IsNearMRT = false, IsNewlyListed = false, AllowsPets = true, ShortTermRent = false,
                BuildingType = "公寓", SizePing = 6.4, Floor = 3, TotalFloors = 5,
                HasAC = true, HasWasher = false, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = false, HasBalcony = false
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "北投區", Type = "雅房", Rent = 4400, Rooms = 1, Bathrooms = 0,
                IsNearMRT = true, IsNewlyListed = true, AllowsPets = false, ShortTermRent = true,
                BuildingType = "公寓", SizePing = 3.2, Floor = 1, TotalFloors = 4,
                HasAC = false, HasWasher = false, HasFridge = false, HasWaterHeater = true,
                HasGas = true, HasInternet = false, HasBed = true, HasParking = false, HasElevator = false, HasBalcony = false
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "萬華區", Type = "整層住家", Rent = 27000, Rooms = 3, Bathrooms = 2,
                IsNearMRT = true, IsNewlyListed = false, AllowsPets = false, ShortTermRent = false,
                BuildingType = "公寓", SizePing = 23.0, Floor = 2, TotalFloors = 5,
                HasAC = true, HasWasher = true, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = false, HasParking = false, HasElevator = false, HasBalcony = true
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "大同區", Type = "獨立套房", Rent = 14800, Rooms = 1, Bathrooms = 1,
                IsNearMRT = true, IsNewlyListed = true, AllowsPets = true, ShortTermRent = false,
                BuildingType = "電梯大樓", SizePing = 11.8, Floor = 8, TotalFloors = 12,
                HasAC = true, HasWasher = true, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = true, HasBalcony = true
            },
            new RentalListing
            {
                LocationCity = "台北市", LocationDistrict = "南港區", Type = "分租套房", Rent = 9300, Rooms = 1, Bathrooms = 1,
                IsNearMRT = true, IsNewlyListed = false, AllowsPets = false, ShortTermRent = true,
                BuildingType = "公寓", SizePing = 7.1, Floor = 4, TotalFloors = 5,
                HasAC = true, HasWasher = false, HasFridge = true, HasWaterHeater = true,
                HasGas = true, HasInternet = true, HasBed = true, HasParking = false, HasElevator = false, HasBalcony = false
            }
        };
        }
    }


}
