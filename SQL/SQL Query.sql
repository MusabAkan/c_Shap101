  select categoryID,  count(*) as  Count into #tmp from Products group by CategoryID  having count(*) < 10

  select c.CategoryName, c.Description from #tmp t
  inner join Categories c on c.CategoryID = t.CategoryID

  drop table #tmp


  
    /*SQL Primary Key  bir  ilgili tabloda kolon bir daha  tekrarlanaz Id'ler dir Bir tabloda 1 tane primary key bulunur.
    Foreign Key ise yabancı anahtar yani başka  bir tablonun Id ait tekrarlanabilir ve tekrarlanamaz özelliklerine sahipdir.(Referans tablo)*/

    --DTO Data Transformatin object olarak karşımıza çıkar 

    select*from Products p
   
    left outer join [Order Details] od on  p.ProductID = od.ProductID
    inner join Orders o on od.OrderID = o.OrderID

 

 select * from orde

 select   c.ContactName as Musteri, p.ProductName as UrunAdi,   sum (od.UnitPrice *  od.Quantity) as Toplam from Orders o
inner join [Order Details] od on od.OrderID = o.OrderID
inner join Products p on od.ProductID = p.ProductID
inner join Customers c on c.CustomerID = o.CustomerID
where c.CustomerID ='VINET'
group by c.ContactName, p.ProductName

select*from Products
 
