// switch
//Console.WriteLine("Enter week day: 1-7:");
//int.TryParse(Console.ReadLine(), out int weekDay);



//switch (weekDay)
//{
//	case 1:
//        Console.WriteLine("Monday");
//		break;
//	case 2:
//        Console.WriteLine("Thuesday");
//		break;
//    case 3:
//        Console.WriteLine("Wednesday");
//        break;
//    case 4:
//        Console.WriteLine("Thursday");
//        break;
//    case 5:
//        Console.WriteLine("Friday");
//        break;
//    case 6:
//        Console.WriteLine("Saturday");
//        break;
//    case 7:
//        Console.WriteLine("Sunday");
//        break;
//    default:
//        Console.WriteLine("Incorrect data");
//		break;
//}


//switch ((weekDays)weekDay)
//{
//	case weekDays.MONDAY:
//		break;
//	case weekDays.THUESDAY:
//		break;
//	case weekDays.WEDNESDAY:
//		break;
//	case weekDays.THURSDAY:
//		break;
//	case weekDays.FRIDAY:
//		break;
//	case weekDays.SATURDAY:
//		break;
//	case weekDays.SUNDAY:
//		break;
//	default:
//		break;
//}

//double.TryParse(Console.ReadLine(), out double numb);

//switch (numb)
//{
//    case 0.5:
//        Console.WriteLine("Salam");
//        break;
//    default:
//        break;
//}

Console.WriteLine("Enter months day: 1-12:");
int.TryParse(Console.ReadLine(), out int month);


//switch ((months)month)
//{
//    case months.JANUARY:
//    case months.MARCH:
//    case months.MAY:
//    case months.JULY:
//    case months.AUGUST:
//    case months.OCTOBER:
//    case months.DECEMBER:
//        Console.WriteLine("31 days");
//        break;
//    case months.FEBRUARY:
//        Console.WriteLine("28 or 29 days");
//        break;
//    case months.APRIL:
//    case months.JUNE:
//    case months.SEPTEMBER:
//    case months.NOVEMBER:
//        Console.WriteLine("30 days");
//        break;
//    default:
//        Console.WriteLine("Incorrect data");
//        break;
//}

switch ((months)month)
{
    case months.JANUARY:
        goto case months.DECEMBER;
    case months.FEBRUARY:
        Console.WriteLine("28 or 29 days");
        break;
    case months.MARCH:
        goto case months.DECEMBER;
    case months.APRIL:
        goto case months.NOVEMBER;
    case months.MAY:
        goto case months.DECEMBER;
    case months.JUNE:
        goto case months.NOVEMBER;
    case months.JULY:
        goto case months.DECEMBER;
    case months.AUGUST:
        goto case months.DECEMBER;
    case months.SEPTEMBER:
        goto case months.NOVEMBER;
    case months.OCTOBER:
        goto case months.DECEMBER;
    case months.NOVEMBER:
        Console.WriteLine("30 days");
        break;
    case months.DECEMBER:
        Console.WriteLine("31 days");
        break;
    default:
        Console.WriteLine("Incorrect data");
        break;
}

enum weekDays
{
    MONDAY = 1,
    THUESDAY,
    WEDNESDAY,
    THURSDAY,
    FRIDAY,
    SATURDAY,
    SUNDAY
}

enum months
{
    JANUARY = 1,
    FEBRUARY,
    MARCH,
    APRIL,
    MAY,
    JUNE,
    JULY,
    AUGUST,
    SEPTEMBER,
    OCTOBER,
    NOVEMBER,
    DECEMBER
}

