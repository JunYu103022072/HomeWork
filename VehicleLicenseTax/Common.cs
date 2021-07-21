//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Collections;

//namespace HW_W3
//{
//    class Common
//    {
//        public static List<Car_Tax> autobike_Tax = new List<Car_Tax>();
//        public static List<Car_Tax> truck_Tax = new List<Car_Tax>();
//        public static List<Car_Tax> coach_Tax = new List<Car_Tax>();
//        public static List<Car_Tax> mysmalltruck_Tax = new List<Car_Tax>();
//        public static List<Car_Tax> smalltruck_Tax = new List<Car_Tax>();

//        public static void Car()
//        {
//            autobike_Tax.Add(new Car_Tax("機車", "150以下 / 12HP以下(12.2PS以下)", 0));
//            autobike_Tax.Add(new Car_Tax("機車", "151-250 / 12.1-20HP(12.3-20.3PS)", 800));
//            autobike_Tax.Add(new Car_Tax("機車", "251-500 / 20.1HP以上(20.4PS以上)", 1620));
//            autobike_Tax.Add(new Car_Tax("機車", "501-600", 2160));
//            autobike_Tax.Add(new Car_Tax("機車", "601-1200", 4320));
//            autobike_Tax.Add(new Car_Tax("機車", "1201-1800", 7120));
//            autobike_Tax.Add(new Car_Tax("機車", "1801或以上", 11230));
//            truck_Tax.Add(new Car_Tax("貨車", "500以下", 900));
//            truck_Tax.Add(new Car_Tax("貨車", "501-600", 1080));
//            truck_Tax.Add(new Car_Tax("貨車", "601-1200", 1800));
//            truck_Tax.Add(new Car_Tax("貨車", "1201-1800", 2700));
//            truck_Tax.Add(new Car_Tax("貨車", "1801-2400", 3600));
//            truck_Tax.Add(new Car_Tax("貨車", "2401-3000 / 138HP以下(140.1PS以下)", 4500));
//            truck_Tax.Add(new Car_Tax("貨車", "3001-3600", 5400));
//            truck_Tax.Add(new Car_Tax("貨車", "3601-4200 / 138.1-200HP(140.2-203.0PS)", 6300));
//            truck_Tax.Add(new Car_Tax("貨車", "4201-4800", 7200));
//            truck_Tax.Add(new Car_Tax("貨車", "4801-5400 / 200.1-247HP(203.1-250.7PS)", 8100));
//            truck_Tax.Add(new Car_Tax("貨車", "5401-6000", 9000));
//            truck_Tax.Add(new Car_Tax("貨車", "6001-6600 / 247.1-286HP(250.8-290.3PS)", 9900));
//            truck_Tax.Add(new Car_Tax("貨車", "6601-7200", 10800));
//            truck_Tax.Add(new Car_Tax("貨車", "7201-7800 / 286.1-336HP(290.4-341.0PS)", 11700));
//            truck_Tax.Add(new Car_Tax("貨車", "7801-8400", 12600));
//            truck_Tax.Add(new Car_Tax("貨車", "8401-9000 / 336.1-361HP(341.1-366.4PS)", 13500));
//            truck_Tax.Add(new Car_Tax("貨車", "9001-9600", 14400));
//            truck_Tax.Add(new Car_Tax("貨車", "9601-10200 / 361.1HP以上(366.5PS以上)", 15300));
//            truck_Tax.Add(new Car_Tax("貨車", "10201以上", 16200));
//            coach_Tax.Add(new Car_Tax("大客車", "600以下", 1080));
//            coach_Tax.Add(new Car_Tax("大客車", "601-1200", 1800));
//            coach_Tax.Add(new Car_Tax("大客車", "1201-1800", 2700));
//            coach_Tax.Add(new Car_Tax("大客車", "1801-2400", 3600));
//            coach_Tax.Add(new Car_Tax("大客車", "2401-3000 / 138HP以下(140.1PS以下)", 4500));
//            coach_Tax.Add(new Car_Tax("大客車", "3001-3600", 5400));
//            coach_Tax.Add(new Car_Tax("大客車", "3601-4200 / 138.1-200HP(140.2-203.0PS)", 6300));
//            coach_Tax.Add(new Car_Tax("大客車", "4201-4800", 7200));
//            coach_Tax.Add(new Car_Tax("大客車", "4801-5400 / 200.1-247HP(203.1-250.7PS)", 8100));
//            coach_Tax.Add(new Car_Tax("大客車", "5401-6000", 9000));
//            coach_Tax.Add(new Car_Tax("大客車", "6001-6600 / 247.1-286HP(250.8-290.3PS)", 9900));
//            coach_Tax.Add(new Car_Tax("大客車", "6601-7200", 10800));
//            coach_Tax.Add(new Car_Tax("大客車", "7201-7800 / 286.1-336HP(290.4-341.0PS)", 11700));
//            coach_Tax.Add(new Car_Tax("大客車", "7801-8400", 12600));
//            coach_Tax.Add(new Car_Tax("大客車", "8401-9000 / 336.1-361HP(341.1-366.4PS)", 13500));
//            coach_Tax.Add(new Car_Tax("大客車", "9001-9600", 14400));
//            coach_Tax.Add(new Car_Tax("大客車", "9601-10200 / 361.1HP以上(366.5PS以上)", 15300));
//            coach_Tax.Add(new Car_Tax("大客車", "10201以上", 16200));
//            smalltruck_Tax.Add(new Car_Tax("營業用小客車", "500以下 / 38HP以下(38.6PS以下)", 900));
//            smalltruck_Tax.Add(new Car_Tax("營業用小客車", "501~600 / 38.1-56HP(38.7-56.8PS)", 1260));
//            smalltruck_Tax.Add(new Car_Tax("營業用小客車", "601~1200 / 56.1-83HP(56.9-84.2PS)", 2160));
//            smalltruck_Tax.Add(new Car_Tax("營業用小客車", "1201~1800 / 83.1-182HP(84.3-184.7PS)", 3060));
//            smalltruck_Tax.Add(new Car_Tax("營業用小客車", "1801~2400 / 182.1-262HP(184.8-265.9PS)", 6480));
//            smalltruck_Tax.Add(new Car_Tax("營業用小客車", "2401~3000 / 262.1-322HP(266-326.8PS)", 9900));
//            smalltruck_Tax.Add(new Car_Tax("營業用小客車", "3001-4200 / 322.1-414HP(326.9-420.2PS)", 16380));
//            smalltruck_Tax.Add(new Car_Tax("營業用小客車", "4201-5400 / 414.1-469HP(420.3-476.0PS)", 24300));
//            smalltruck_Tax.Add(new Car_Tax("營業用小客車", "5401-6600 / 469.1-509HP(476.1-516.6PS)", 33660));
//            smalltruck_Tax.Add(new Car_Tax("營業用小客車", "6601-7800 / 509.1HP以上(516.7PS以上)", 44460));
//            smalltruck_Tax.Add(new Car_Tax("營業用小客車", "7801以上", 56700));
//            mysmalltruck_Tax.Add(new Car_Tax("自用小客車", "500以下 / 38HP以下(38.6PS以下)", 1620));
//            mysmalltruck_Tax.Add(new Car_Tax("自用小客車", "501~600 / 38.1-56HP(38.7-56.8PS)", 2160));
//            mysmalltruck_Tax.Add(new Car_Tax("自用小客車", "601~1200 / 56.1-83HP(56.9-84.2PS)", 4320));
//            mysmalltruck_Tax.Add(new Car_Tax("自用小客車", "1201~1800 / 83.1-182HP(84.3-184.7PS)", 7120));
//            mysmalltruck_Tax.Add(new Car_Tax("自用小客車", "1801~2400 / 182.1-262HP(184.8-265.9PS)", 11230));
//            mysmalltruck_Tax.Add(new Car_Tax("自用小客車", "2401~3000 / 262.1-322HP(266-326.8PS)", 15210));
//            mysmalltruck_Tax.Add(new Car_Tax("自用小客車", "3001-4200 / 322.1-414HP(326.9-420.2PS)", 28220));
//            mysmalltruck_Tax.Add(new Car_Tax("自用小客車", "4201-5400 / 414.1-469HP(420.3-476.0PS)", 46170));
//            mysmalltruck_Tax.Add(new Car_Tax("自用小客車", "5401-6600 / 469.1-509HP(476.1-516.6PS)", 69690));
//            mysmalltruck_Tax.Add(new Car_Tax("自用小客車", "6601-7800 / 509.1HP以上(516.7PS以上)", 117000));
//            mysmalltruck_Tax.Add(new Car_Tax("自用小客車", "7801以上", 151200));
//        }
//    }
//}
