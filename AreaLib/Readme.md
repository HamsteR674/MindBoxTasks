﻿Задание №1

Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. 

Дополнительно к работоспособности оценим:

    -Юнит-тесты

    -Легкость добавления других фигур

    -Вычисление площади фигуры без знания типа фигуры в compile-time

    -Проверку на то, является ли треугольник прямоугольным

Комментарий: Есть двоякое понимание условия "Вычисление площади фигуры без знания типа фигуры в compile-time", предпожил, что требуется разделить абстрактный класс для последующего использования примитивов через IoC.
С другой стороны, может подразумеваться использование кастомных фигур, для которых потребуется передать формулу расчета площади для кастомной фигуры. 
Это можно сделать через передачу строки с лямбда-выражением через строку, ее считывание и динамическую компиляцию этой строки через компилятор Roslyn. 
На мой взгляд, такая цель в задаче не ставилась (в т.ч. для внешнего клиента использование библиотеки в таком виде будет сложно), и в текущем решении рассматриваться не будет.

Задание №2

В базе данных MS SQL Server есть продукты и категории. 
Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. 

Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». 

Если у продукта нет категорий, то его имя все равно должно выводиться.