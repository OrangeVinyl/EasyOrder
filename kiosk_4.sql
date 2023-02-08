DROP TABLE customer;

CREATE TABLE customer
(
    customer_id    INTEGER NOT NULL,
    customer_phone    NVARCHAR2(11) NOT NULL,
    customer_password    NVARCHAR2(4) NOT NULL,
    customer_point    NUMBER(10) NOT NULL
);

COMMENT ON COLUMN customer.customer_id IS '고객번호';

COMMENT ON COLUMN customer.customer_phone IS '전화번호';

COMMENT ON COLUMN customer.customer_password IS '비밀번호';

COMMENT ON COLUMN customer.customer_point IS '포인트잔액';

COMMENT ON TABLE customer IS '고객';

CREATE UNIQUE INDEX customer_PK ON customer
( customer_id );

ALTER TABLE customer
 ADD CONSTRAINT customer_PK PRIMARY KEY ( customer_id )
 USING INDEX customer_PK;


DROP TABLE order_detail;

CREATE TABLE order_detail
(
    order_id    INTEGER NOT NULL,
    product_id    INTEGER NOT NULL,
    order_count    INTEGER NOT NULL,
    order_price    NUMBER(10) NOT NULL
);

COMMENT ON COLUMN order_detail.order_id IS '주문번호';

COMMENT ON COLUMN order_detail.product_id IS '상품번호';

COMMENT ON COLUMN order_detail.order_count IS '주문갯수';

COMMENT ON COLUMN order_detail.order_price IS '주문단가';

COMMENT ON TABLE order_detail IS '주문정보';

CREATE UNIQUE INDEX order_detail_PK ON order_detail
( order_id,product_id );

ALTER TABLE order_detail
 ADD CONSTRAINT order_detail_PK PRIMARY KEY ( order_id,product_id )
 USING INDEX order_detail_PK;


DROP TABLE order_list;

CREATE TABLE order_list
(
    order_id    INTEGER NOT NULL,
    order_date    DATE NOT NULL,
    order_total_price    NUMBER(10) NOT NULL,
    order_state    NVARCHAR2(1) NOT NULL,
    customer_id    INTEGER NOT NULL,
    order_method    NVARCHAR2(10) NOT NULL
);

COMMENT ON COLUMN order_list.order_id IS '주문번호';

COMMENT ON COLUMN order_list.order_date IS '주문일';

COMMENT ON COLUMN order_list.order_total_price IS '주문총액';

COMMENT ON COLUMN order_list.order_state IS '주문상태';

COMMENT ON COLUMN order_list.customer_id IS '고객번호';

COMMENT ON COLUMN order_list.order_method IS '결제방법';

COMMENT ON TABLE order_list IS '주문목록';

CREATE UNIQUE INDEX order_list_PK ON order_list
( order_id );

ALTER TABLE order_list
 ADD CONSTRAINT order_list_PK PRIMARY KEY ( order_id )
 USING INDEX order_list_PK;


DROP TABLE product;

CREATE TABLE product
(
    product_id    INTEGER NOT NULL,
    product_type_id    INTEGER NOT NULL,
    product_name    NVARCHAR2(50) NOT NULL,
    product_img    BLOB,
    product_desc    NVARCHAR2(50) NOT NULL,
    product_price    NUMBER NOT NULL,
    product_rank    INTEGER
);

COMMENT ON COLUMN product.product_id IS '상품번호';

COMMENT ON COLUMN product.product_type_id IS '상품분류번호';

COMMENT ON COLUMN product.product_name IS '상품이름';

COMMENT ON COLUMN product.product_img IS '이미지';

COMMENT ON COLUMN product.product_desc IS '설명';

COMMENT ON COLUMN product.product_price IS '가격';

COMMENT ON COLUMN product.product_rank IS '인기정보순위';

COMMENT ON TABLE product IS '상품';

CREATE UNIQUE INDEX product_PK ON product
( product_id );

ALTER TABLE product
 ADD CONSTRAINT product_PK PRIMARY KEY ( product_id )
 USING INDEX product_PK;


DROP TABLE product_type;

CREATE TABLE product_type
(
    product_type_id    INTEGER NOT NULL,
    product_type_name    VARCHAR2(50) NOT NULL
);

COMMENT ON COLUMN product_type.product_type_id IS '상품분류번호';

COMMENT ON COLUMN product_type.product_type_name IS '상품분류이름';

COMMENT ON TABLE product_type IS '상품분류';

CREATE UNIQUE INDEX product_type_PK ON product_type
( product_type_id );

ALTER TABLE product_type
 ADD CONSTRAINT product_type_PK PRIMARY KEY ( product_type_id )
 USING INDEX product_type_PK;


DROP TABLE sales;

CREATE TABLE sales
(
    order_id    INTEGER NOT NULL,
    sales_date    DATE NOT NULL,
    sales_income    NUMBER(10) NOT NULL,
    sales_expenditure    NUMBER(10) NOT NULL
);

COMMENT ON COLUMN sales.order_id IS '주문번호';

COMMENT ON COLUMN sales.sales_date IS '매출일자';

COMMENT ON COLUMN sales.sales_income IS '매출액';

COMMENT ON COLUMN sales.sales_expenditure IS '지출액';

COMMENT ON TABLE sales IS '매출';

CREATE UNIQUE INDEX sales_PK ON sales
( order_id );

ALTER TABLE sales
 ADD CONSTRAINT sales_PK PRIMARY KEY ( order_id )
 USING INDEX sales_PK;


DROP TABLE stock_quantity;

CREATE TABLE stock_quantity
(
    product_id    INTEGER NOT NULL,
    product_quantity    INTEGER NOT NULL
);

COMMENT ON COLUMN stock_quantity.product_id IS '상품번호';

COMMENT ON COLUMN stock_quantity.product_quantity IS '재고수량';

COMMENT ON TABLE stock_quantity IS '재고현황';

CREATE UNIQUE INDEX stock_quantity_PK ON stock_quantity
( product_id );

ALTER TABLE stock_quantity
 ADD CONSTRAINT stock_quantity_PK PRIMARY KEY ( product_id )
 USING INDEX stock_quantity_PK;

drop sequence p_id;
drop sequence p_t_id;
drop sequence o_id;
drop sequence c_id;

CREATE SEQUENCE p_id
       INCREMENT BY 1
       START WITH 1
       MINVALUE 1
       MAXVALUE 9999
       NOCYCLE
       NOCACHE
       NOORDER;
CREATE SEQUENCE p_t_id
       INCREMENT BY 1
       START WITH 1
       MINVALUE 1
       MAXVALUE 9999
       NOCYCLE
       NOCACHE
       NOORDER;
CREATE SEQUENCE o_id
       INCREMENT BY 1
       START WITH 1
       MINVALUE 1
       MAXVALUE 9999
       NOCYCLE
       NOCACHE
       NOORDER;
CREATE SEQUENCE c_id
       INCREMENT BY 1
       START WITH 1
       MINVALUE 1
       MAXVALUE 9999
       NOCYCLE
       NOCACHE
       NOORDER;
