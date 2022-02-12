SELECT * FROM ProductsCategories
/* Так как у нас здесь база данных Многие ко многим, было бы выгодно
создать промежуточную таблицу ProductsCategories, в которой бы и были нужные нам данные (ProductId) и (CategorieId)
и тогда нужные нам данные находились бы именнов в ней, а создать её можно было бы следующим образом:
create table Database.ProductsCategories 
(
	ProductId foreign key references Database.Products(ProductId),
	CategoryId foreign key references Database.Categories(CategoryId),
	primary key(ProductId, CategoryId)
)*/