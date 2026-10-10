// // int[] recordBooks = { 1042, 1058, 1071, 1093, 1105 };
// // int target = 451;
// // bool found = false;
// // foreach (int number in recordBooks) {
// //     if (number == target)
// //     {
// //         found = true;
// //         break;
// //     }
// // }
// // Console.WriteLine(found ? "Студент найден" : "Студент не найден");

// // int variant = 17; 
// // bool isPrime = true;
// // if (variant <= 1) {
// //     isPrime = false;
// // } else {
// //     for (int divisor = 2; divisor < variant; divisor++) {
// //         if (variant % divisor == 0){
// //             isPrime = false;
// //             break; 
// //         }
// //     }
// // }
// // Console.WriteLine(isPrime ? "Номер варианта простой" : "Номер варианта составной");

// // int[] pointsPerLab = { 8, -1, 10, 9, -1, 7 };
// // int sum = 0;
// // int count = 0;
// // foreach (int points in pointsPerLab){
// //     if (points < 0) {
// //         continue; 
// //     }
// //     sum += points;
// //     count ++;
// // }
// // Console.WriteLine($"Сумма баллов за сданные работы: {sum}");
// // Console.WriteLine($"Работ сдано: {count}");

// // int[] groupIds = { 101, 104, 107, 104, 110 };
// // bool hasDuplicates = false;
// // for (int i = 0; i < groupIds.Length; i++){
// //     for (int j = i + 1; j < groupIds.Length; j++){
// //         if (groupIds[i] == groupIds[j]){
// //             hasDuplicates = true;
// //             Console.WriteLine($"{groupIds[i]} {groupIds[j]}");
// //             break;
// //         }
// //     }
// //     if (hasDuplicates) {
// //         break;
// //     }
// // }
// // Console.WriteLine(hasDuplicates ? "Есть повторяющиеся номера" : "Все номера уникальны");

// int days =5;
// int lessonsPerDay = 6;
// bool found = false;
// for (int day = 1; day <= days && !found; day++) {
//     for (int lesson = 1; lesson <= lessonsPerDay; lesson++) {
//         bool isFree = (day == 3 && lesson == 4); 
//         if (isFree) {
//             Console.WriteLine($"Свободный слот: день {day}, урок {lesson}");
//             found = true;
//             break;
//         }
//     }
// }
// if (!found) {
//     Console.WriteLine("Свободных слотов нет");
// }

/*
адача А. Дан массив int[] и искомое число. 
С помощью линейного поиска (флаг 
+ break) найдите индекс искомого числа или сообщите, 
что его нет. 
*/
// int[] number = {1,3,7,15,2};
// int num = 7;
// bool flag = false;
// for (int i = 0; i<number.Length; i++) {
//     if (number[i] == num) {
//         flag = true;
//         break;
//     }
// }
// Console.WriteLine(flag ? "Число найдено" : "Число не найдено");

/*
Задача В. Дан массив int[]. 
Посчитайте сумму только чётных чисел, используя 
continue для пропуска нечётных. 
*/
// int[] number = {1,2,3,4,5,6,7,8,9,10};
// int sum = 0;
// for (int i = 0; i<number.Length; i++) {
//     if (number[i] % 2 == 1) {
//         continue;
//     }
//     sum += number[i];
// }
// Console.WriteLine(sum);

// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname)){
//     Console.WriteLine("Фамилия не введена. Завершение работы.");
//     return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
//     .OrderBy(_ => rnd.Next())
//     .Take(2)
//     .OrderBy(x => x)
//     .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

/*
Вариант 6. Проверка на отсортированность 
Дан массив int[]. Проверьте, отсортирован ли 
он по возрастанию (каждый следующий элемент не меньше 
предыдущего). При первом нарушении порядка 
остановите проверку через break. 
*/
// int[] number = {1,2,3,4,5,6,777,8};
// bool flag = true;
// for (int i = 0; i<number.Length;i++) {
//     for (int j = i+1; j<number.Length;j++) {
//         if (number[i]>=number[j]) {
//             flag = false;
//             break;
//         }
//     }
// }
// Console.WriteLine(flag ? "По порядку" : "Порядок нарушен");

/*
Вариант 7. Положительные числа до первого отрицательного 
Дан массив int[]. Посчитайте, сколько положительных чисел 
стоит подряд в начале массива, до первого отрицательного 
(включая ноль как «не отрицательное»). 
Остановите подсчёт через break, как только встретите 
отрицательное число.
*/
int[] number = {1,2,3,4,5,6,7,8,-10,13};
int count = 0;
for (int i = 0; i<number.Length; i++){
    if (number[i]<0) {
        break;
    }
    count++;
}
Console.WriteLine($"Положительных чисел подряд: {count}");