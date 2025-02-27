## Тестове завдання
> <sub> Розроблений функціонал розміщений у гілці dev. </sub>

### Виконані завдання

#### 1. Робота з ордерами, продукцією та клієнтами
Реалізовано управління замовленнями (Orders), продуктами (Products) та клієнтами (Clients).
Створено моделі даних та налаштовані зв'язки між ними.
Використано Entity Framework Core для роботи з базою даних.

#### 2. Метод отримання останніх покупців
Реалізовано метод для отримання списку клієнтів, які здійснювали покупки за останні N днів.
Вхідний параметр: N – кількість днів.
Вихідні дані: список клієнтів (ID, ПІБ) та дата їх останньої покупки.

#### 3. Метод отримання іменинників
Реалізовано метод для отримання списку клієнтів, які святкують день народження у певний день.
Вхідний параметр: дата народження.
Вихідні дані: список клієнтів, що народилися у вказаний день.

#### 4. Метод отримання затребуваних категорій
Реалізовано метод для визначення категорій продуктів, які купував певний клієнт.
Вхідний параметр: ідентифікатор клієнта.
Вихідні дані: список категорій із зазначенням кількості придбаних одиниць.

#### Технології та інструменти
ASP.NET Core Web API
Entity Framework Core
SQLite
Postman
