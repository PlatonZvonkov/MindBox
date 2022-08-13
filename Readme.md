# MindBox
Задание1:
/Shapes
/ShapesTests

Задание2:
Запрос для получения всех пар включая имена без категорий:

SELECT Product.Name, Category.Name FROM Product

LEFT JOIN Product_Category ON Product.Id = Product_Category.ProductId

LEFT JOIN Category ON Product_Category.CategoryId = Category.Id;


-
Визуальная схема базы данных приложена в репозитории файлом - SQLDiagram.png

Результат выполнения запроса файлом - SQLExecuted.jpg

База данных из двух таблиц Product и Category, связь многие-ко-многим через таблицу Product_Category с композитным primary key.

