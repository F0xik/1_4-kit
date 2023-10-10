double price, discount; int count;
Console.WriteLine("Введите стоимость товара:"); price = Convert.ToDouble(Console.ReadLine()); // Ввод стоимости товара
Console.WriteLine("Укажите количество: "); count = Convert.ToInt32(Console.ReadLine()); // Ввод количества
Console.WriteLine("Укажите скидку: "); discount = Convert.ToDouble(Console.ReadLine()); // Ввод скидки
Console.WriteLine($"Итоговая стоимость с учетом скидки {discount}% составляет: {(price * count) - ((price * count) / 100 * discount)}");
