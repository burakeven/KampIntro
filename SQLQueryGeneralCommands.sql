--SELECT
select ContactName Adi, CompanyName SirketAdi, City Sehir from Customers

Select *from Customers where City='London'

--case insensitive
select *from Products where CategoryID=1 or CategoryID=3 -- categoryId 1 ve 3 olanları getirdik.
select *from Products where CategoryID=1 AND UnitPrice>=10 -- <> bu 10'dan farklı olanları getir demek -- Intelisense(yazarken altta yazacagin seyin cikmasi)

select *from Products where CategoryID=1 order by UnitPrice desc -- ascending --descending

select count(*) Adet from Products

select CategoryID, count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories on Products.CategoryID=Categories.CategoryID where Products.UnitPrice>10 

--DTO - Data Transformation Object

select *from Products p inner join [Order Details] od on p.ProductID=od.ProductID
inner join Orders o on o.OrderID=od.OrderID--köşeli parantez kullanma sebebi order details'in tek parça olduğunu gösterebilmek, başka bir anlamı yok.
-- left join: solda olup sağda olmayanlarıda getir demektir.

select *from Customers c left join Orders o on o.CustomerID=o.CustomerID where o.CustomerID is null

-- SQL w3schools.com basic codes:
--select
select CompanyName sirket, ContactName CN from Customers
select *from Customers
 --select distinct
 select distinct City from Customers
 select count(distinct City) from Customers --o sütun içerisinde farklı degerleri getirir. Birkaç tane aynı varsa onu tek olarak yazdırır.
 --where
 select * from Customers where CustomerID='FOLKO';
 --and, or, not
 SELECT * FROM Customers
WHERE Country='Germany' AND City='Berlin';

 select City from Customers where NOT City='Berlin'

 SELECT * FROM Customers
WHERE City='Berlin' OR City='München';

SELECT *FROM CUSTOMERS WHERE Country='Germany' AND (City='Berlin' OR City='München')
--Order By
SELECT * FROM Customers
ORDER BY Country -- asc artan desc azalan

SELECT * FROM Customers
ORDER BY Country ASC, ContactName DESC;
--insert into
insert into Customers(CustomerID,CompanyName, ContactName, Country) values ('Sav','Savarona', 'Burak Even', 'Turkey')
--Null Values
select  *from Customers where Address IS NULL
select *from Customers where Address IS NOT NULL
--Update
Update Customers set ContactName='Burak Even' , City='Bursa' where CustomerID='ANATR'
--Delete
Delete from Customers where Country='Turkey' --Ülke olarak Turkey değeri olan değerlerin hepsi silindi.
--Select top
select top 3 *from Customers --tabloda ilk üçü getirir.
SELECT TOP 50 PERCENT * FROM Customers; -- yüzde olarak kayıtları gösterir. Toplam kaç kayıt varsa bunların %50'sini gösterdi.

SELECT TOP 3 * FROM Customers
WHERE Country='Germany';
--Min and Max
select min(UnitPrice) as SmallestPrice from Products -- products tablosundan en düşük fiyatı gösterir
select max(UnitPrice) as HighestPrice from Products -- products tablosundan en yüksek fiyatı gösterir.

select count(*) from Customers where Country='Germany' -- ülke Germany olan kaç tane satır olduğunu gösterir.
select count(ProductID) from Products -- Kaç adet ürün id'si olduğunu yazar

select avg(UnitPrice) from Products -- fiyat ortalaması alır
select sum(UnitPrice) from Products -- fiyat toplamı yapar 
--LIKE
select *from Customers where ContactName LIKE 'a%' -- Customers tablosundan ContactName'i a ile başlayanları getirmiş olduk.
select *from Customers where ContactName LIKE '%a' -- Customers tablosundan ContactName'i a ile bitenleri getirmiş olduk.

select *from Customers Where ContactName LIKE '%Bur%' -- ContactName içerisinde Bur kelimesi geçen değerleri getirir.
 --'_r%' ikinci harfinde r harfi olanları getirir
 --'a_%' a ile başlayan ve en az iki harf uzunluğunda kelimeleri getirir
 --'a__%' a ile başlayan ve en az üç harf uzunluğunda olan kelimeleri getirir.
 --'a%o' a ile başlayan ve o ile biten kelimeleri getirir.

 SELECT * FROM Customers
WHERE Country IN ('Germany', 'France', 'UK');

SELECT * FROM Customers
WHERE Country IN (SELECT Country FROM Suppliers); --Sql ifadesi, tedarikçilerle aynı ülkelerden gelen tüm müşterileri seçer

select UnitPrice from Products where UnitPrice between 1 and 200 -- Products tablosundan UnitPrice'ı 1 ve 200 arasında olan tüm degeleri UnitPrice altında gösterir.
select UnitPrice from Products where UnitPrice not between 50 and 200 order by UnitPrice -- UnitPrice'ı 50-200 arasında olmayanları getirir. Artan şekilde UnitPrice'ı sıralarç

SELECT * FROM Products
WHERE UnitPrice BETWEEN 10 AND 20
AND CategoryID NOT IN (1,2,3); -- UnitPrice'ı 10 ve 20 arasında olanları ayrıca içerisinde 1,2,3 CategoryID olmayanları getirir.

SELECT * FROM Products
WHERE ProductName BETWEEN 'Carnarvon Tigers' AND 'Mozzarella di Giovanni'
ORDER BY ProductName;

--ALIASES
SELECT CustomerName, Address + ', ' + PostalCode + ' ' + City + ', ' + Country AS Address
FROM Customers; --İki sütunda gösterir, ilk sütun CustomerName adında diğeri ise Address adında olacaktır fakat bu ikinci sütun içerisinde yukarıda belirtilen
--addresten itibaren aynı satır içerisine yazarak bir adres bloğu elde edilmesini sağlar.

SELECT o.OrderID, o.OrderDate, c.ContactName
FROM Customers AS c, Orders AS o
WHERE c.ContactName='Burak Even' AND c.CustomerID=o.CustomerID -- aliases kullanıldı, yani takma ad verildi. Bunun ardından
-- Customers içerisinde ContactName'i Burak Even olan ve c.CustomerID ile o.CustomerID'si eşit olan verileri getirir.


--JOINS
SELECT Orders.OrderID, Customers.ContactName, Orders.OrderDate
FROM Orders
inner JOIN Customers ON Orders.CustomerID=Customers.CustomerID;
--INNER JOIN
select Orders.OrderID, Customers.ContactName,Customers.Country from Orders inner join Customers on Orders.CustomerID=Customers.CustomerID
--THREE TABLES JOIN
SELECT Orders.OrderID, Customers.ContactName, Shippers.CompanyName
FROM ((Orders
INNER JOIN Customers ON Orders.CustomerID = Customers.CustomerID)
INNER JOIN Shippers ON Orders.ShipperID = Shippers.ShipperID); --burada ShipperID'de veriler string verilmediği için patladık ama kullanımı böyle.
--Left Join
select Orders.OrderDate, Customers.ContactName from Orders left join Customers on Orders.CustomerID=Customers.CustomerID 
--solda yani Orders'da bulunan tüm değerler ile Customerla kesişen değerleri de dahil eder.
select Customers.ContactName, Orders.OrderID from Customers left join Orders on Customers.CustomerID=Orders.CustomerID
--Right Join
SELECT Orders.OrderID, Employees.LastName, Employees.FirstName
FROM Orders
RIGHT JOIN Employees ON Orders.EmployeeID = Employees.EmployeeID
ORDER BY Orders.OrderID;
--Full Outer Join
select Customers.ContactName, Orders.OrderDate from Customers full outer join Orders on Customers.CustomerID=Orders.CustomerID
--Union
select City from Customers
UNION
select City from Suppliers order by City --Customers ve Suppliers'den City değerlerini distinct olarak çeker.
--
SELECT 'Customer' AS Type, ContactName, City, Country
FROM Customers
UNION
SELECT 'Supplier', ContactName, City, Country
FROM Suppliers; -- Customer ve Supplier'den belirli alanları alarak Union eder. Elbette bu veriler distinct olarak yansıtılır.
--Group By
SELECT COUNT(CustomerID) as Count, Country
FROM Customers group by Country --Hangi ülkeden kaç tane müşteri olduğunu gösterir.

SELECT COUNT(CustomerID), Country
FROM Customers
GROUP BY Country
ORDER BY COUNT(CustomerID) DESC;

SELECT Shippers.ShipperName, COUNT(Orders.OrderID) AS NumberOfOrders FROM Orders
LEFT JOIN Shippers ON Orders.ShipperID = Shippers.ShipperID
GROUP BY ShipperName; --Kullanım doğru fakat benim database'imde böyle bir sütun falan olmadığı için hata verir, joinle kullanımı böyle.
--Having Clause
--WHERE anahtar sözcüğü toplama işlevleriyle kullanılamadığından, HAVING yan tümcesi SQL'e eklendi.
SELECT COUNT(CustomerID), Country
FROM Customers
GROUP BY Country
HAVING COUNT(CustomerID) > 5;
--Exist
SELECT Suppliers.CompanyName
FROM Suppliers
WHERE EXISTS (SELECT ProductName FROM Products WHERE Products.SupplierID = Suppliers.supplierID AND UnitPrice < 20);
--Any(alt sorgulardan herhangi biri doğruysa onu döndürür) -- ALL(Alt değerlerin hepsinin doğru olması lazım ki döndürsün)
SELECT ProductName
FROM Products
WHERE ProductID = ANY
  (SELECT ProductID
  FROM [Order Details]
  WHERE Quantity = 10); --ANLAŞILMADI.

  SELECT ProductName
FROM Products
WHERE ProductID = ANY
  (SELECT ProductID
  FROM OrderDetails
  WHERE Quantity > 99); --99'dan büyük bir kalite değeri yakalarsa true döndürecek çünkü 1 tane değer yakalaması yeterli. All'da ise hepsinin sağlanması lazım.
  --SELECT INTO -- Verileri bir tablodan diğer bir tabloya kopyalar.
  SELECT * INTO CustomersBackup2021
FROM Customers;

SELECT CustomerName, ContactName INTO CustomersBackup2017
FROM Customers;

SELECT * INTO CustomersGermany
FROM Customers
WHERE Country = 'Germany';
--Insert Into
INSERT INTO Customers (CustomerName, City, Country)
SELECT SupplierName, City, Country FROM Suppliers;
--Case
SELECT OrderID, Quantity,
CASE
    WHEN Quantity > 30 THEN 'The quantity is greater than 30'
    WHEN Quantity = 30 THEN 'The quantity is 30'
    ELSE 'The quantity is under 30'
END AS QuantityText
FROM OrderDetails;
--Stored Procedure
CREATE PROCEDURE SelectAllCustomers
AS
SELECT * FROM Customers
GO;

EXEC SelectAllCustomers;

--ÖDEV 2

Select pro.ProductName as ÜrünAdi,sum(Od.UnitPrice*od.Quantity) as KazanilanToplam from [Order Details] Od
inner join Products pro on Od.ProductID=pro.ProductID inner join Orders on od.OrderID=Orders.OrderID 
group by pro.ProductName order by KazanilanToplam