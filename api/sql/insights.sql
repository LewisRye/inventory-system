-- CREATE STOCK BY TYPE CHART
SELECT SUM(number_in_stock) AS Stock, category_name
FROM product, category WHERE product.category_id = category.category_id
GROUP BY category.category_name;

-- CREATE DAILY ORDERS CHART
SELECT COUNT(*) AS Orders, order_date AS Date
FROM customer_orders WHERE order_date BETWEEN DATE('now')-7 AND DATE('now')
GROUP BY order_date;

-- CREATE BEST SELLERS CHART
SELECT SUM(customer_order_details.quantity_ordered) AS Quantity, product.Product_Name AS Name FROM customer_order_details
INNER JOIN product ON product.product_id = customer_order_details.product_id
GROUP BY customer_order_details.product_id, product_name
ORDER BY SUM(quantity_ordered) DESC LIMIT 5;

-- CREATE TOTAL ITEMS TEXT
SELECT SUM(product.number_in_stock) FROM product;

-- CREATE WEEKLY PROFIT TEXT
SELECT SUM((1.2 * Product.Buy_Price) *
customer_order_details.Quantity_Ordered) FROM customer_order_details, product, customer_orders
WHERE product.product_id = customer_order_details.product_id
AND customer_orders.order_id = customer_order_details.order_id
AND customer_orders.order_date BETWEEN DATE('now')-7 AND DATE('now');

-- CREATE WEEKLY ORDERS TEXT
SELECT COUNT(customer_orders.order_id) FROM customer_orders
WHERE customer_orders.order_date BETWEEN DATE('now')-7 AND DATE('now');