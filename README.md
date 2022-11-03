# Тестовое задание для Mindbox
Библиотека для вычесления площадей круга и треугольника. Также присутствуют unit-тесты
<br/>
SQL запрос для второго задания:
<br/>
SELECT p.Name, c.Name <br/>
FROM Products AS p <br/>
LEFT OUTER JOIN ProductCategory AS pc <br/>
  ON p.Id = pc.ProductId <br/>
LEFT OUTER JOIN Categories AS c <br/>
  ON c.Id = pc.CategoryId <br/>
