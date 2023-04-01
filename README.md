# GeometricalShapes

Библиотека для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам.

1. Юнит-тесты: Xunit
2. Легкость добавления других фигур: добавить новый класс, реализовать интерфейс IShape.
3. Вычисление площади фигуры без знания типа фигуры в compile-time
```csharp
        IShape circle = new Circle(10);
        IShape triangle = new Triangle(3, 4, 5);

        Console.WriteLine($"Площадь круга: {circle.ComputeArea()}");
        Console.WriteLine($"Площадь треугольника: {triangle.ComputeArea()}");
```
4. Проверка на то, является ли треугольник прямоугольным: метод IsRight().



