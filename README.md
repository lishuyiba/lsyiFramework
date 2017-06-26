
lsyiFramework



### 主要技术
AspNet Core 2.0 + EF +Auofac+ SqlServer2012 + Bootstrap + Layer + ace admin


### 运行方式

使用vs2017打开项目，vs会自动下载所包含的包文件

1、由于目前Core 2.0属于预览版，启动web项目时不能打开网页，可能跟版本有关，等正式版发布后，我再重新发布看看。。。。

2、想要VS2017能编译通过，要修改环境变量，添加MSBuildSdksPath，并设置 Core2.0 SDK的路径，下面是我本机的配置。。。 Core2.0 SDK下载地址：https://download.microsoft.com/download/3/7/F/37F1CA21-E5EE-4309-9714-E914703ED05A/dotnet-dev-win-x64.2.0.0-preview1-005977.exe




### 数据库文件及连接

1、数据库文件位于项目DB文件夹中


数据库连接字符串没有整合到appsettings.json里面，被写死在lsy.Data→Context→LsyiObjectContext.cs 里面，朋友们请自行修改。


参考资料：

http://www.cnblogs.com/flyfish2012/p/3779810.html

http://docs.autofac.org/en/latest/integration/webapi.html

http://www.cnblogs.com/gamehiboy/p/5176618.html

https://docs.microsoft.com/en-us/ef/core/index

http://docs.autofac.org/en/latest/integration/webapi.html

