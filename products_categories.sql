SELECT p.name AS product, STRING_AGG(c.name, ', ') AS categories
FROM products p
         LEFT OUTER JOIN products_categories pc ON p.product_id = pc.product_id
         LEFT OUTER JOIN categories c ON c.category_id = pc.category_id
GROUP BY p.name
ORDER BY p.name;