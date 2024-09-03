SELECT Product.name , Categories.name  FROM Product
LEFT JOIN ProductCategories
	on Product.id_product = ProductCategories.id_product
LEFT JOIN Categories
	on Categories.id_categories = ProductCategories.id_categories
