# GeometricFiguresLib
Библиотека для расчетов и проверок геометрических фигур

### Задача
Напишите библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно реализовать:
- Юнит-тесты
- Легкость добавления других фигур
- Вычисление площади фигуры без знания типа фигуры в compile-time
- Проверку на то, является ли треугольник прямоугольным

### Функции
- Вычисление площади фигур
- Определение фигуры по параметрам фигуры и работа с полученной фигурой - класс UnknownFigure.cs

### Добавление новой фигуры
Для добавления новой фигуры требуется реализовать интерфейс IFigure.cs.
Чтобы добавить возможность определения фигуры по параметрам фигуры, не зная изначально тип, нужно реализовать для новой фигуры интерфейс IFigureFactory.cs и встроить создание инстанции фабрики в метод GetFactories() класса UnknownFigure.cs.

### Примечания
- Класс FigureParameters.cs нужен для сбора параметров фигуры, например, длины сторон, углы. Параметры используются для определения типа фигуры в UnknownFigure.cs.
- Реализации интерфейса IFigureFactory.cs используют параметры из FigureParameters.cs, чтобы точно определить можно ли построить фигуру по переданному набору параметров.

# Задание по SQL
Решение приложено в проекте в файле SqlTask.txt

### Задача
В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.
