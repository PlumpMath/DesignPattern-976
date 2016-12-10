# BUILDER（生成器）

### 类型：*创建型模式*、*对象模式*

## 意图
将一个复杂对象的构建与它的表示分离，使得同样的构建过程可以创建不同的表示。

## 适用性
### 在以下情况可以使用Builder模式：

* 当创建复杂对象的算法应该独立于该对象的组成部分以及它们的装配方式时。

* 当构造过程必须允许被构造的对象有不同的表示时。

## 结构
![](/Builder.png)

## 相关模式

* Abstract Factory与Builder相似，因为它也可以创建复杂对象。主要的区别是Builder模式着重于一步步构造一个复杂对象。而Abstract Factory着重于多个系列的产品对象（简单的或是复杂的）。Builder在最后的一步返回产品，而对于Abstract Factory来说，产品是立即返回的。

* Composite通常是用Builder生成的。

## 案例

> connectionString="Data Source=服务器名;Initial Catalog=数据库名;User ID=用户;Password=密码"


            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            builder.DataSource = ".";
            builder.InitialCatalog = "MyDB";
            builder.UserID = "SA";
            builder.Password = "123456";

            String connectionString = builder.ConnectionString;