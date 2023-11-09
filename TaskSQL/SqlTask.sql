--В базе данных MS SQL Server есть продукты и категории. 
--Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. 
--Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». 
--Если у продукта нет категорий, то его имя все равно должно выводиться.


SELECT
      prd.name,
      cat.[Name]
  FROM [MindboxTest].[dbo].[Category] cat
  right join MindboxTest.dbo.Product prd 
  on prd.Id = cat.productid 