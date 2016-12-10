# ABSTRACT FACTORY（抽象工厂）

### 类型：*创建型模式*、*对象模式*

## 意图
提供一个创建一系列相关或相互依赖对象的接口，而无需指定它们具体的类。

## 适用性
### 在以下情况可以使用Abstract Factory模式：

* 一个系统要独立于它的产品的创建、组合和表示时。

* 一个系统要由多个产品系列中的一个来配置时。

* 当你要强调一系列相关的产品对象的设计以便进行联合使用时。

* 当你提供一个产品类库，而只想显示它们的接口而不是实现时。

## 结构
![](/AbstractFactory.png)

## 相关模式

* AbstractFactory类通常用工厂方法（Factory Method）实现，但它们也可以用
Prototype实现。

* 一个具体的工厂通常是一个单件（Singleton）。

## 案例

[DbProviderFactory](https://msdn.microsoft.com/en-us/library/system.data.common.dbproviderfactory.aspx)


            DbProviderFactory factory = DbProviderFactories.GetFactory("System.Data.SqlClient");

            using (DbConnection connection = factory.CreateConnection())
            {
                connection.ConnectionString = "connectionString";

                DbCommand command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = "select top 10 * from [Table]";
                command.CommandType = CommandType.Text;

                using (DbDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    while (reader.Read())
                    {
                        // todo: get data
                    }
                }
            }