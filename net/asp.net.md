### 新建 web 项目
```
dotnet new webapi -o Demo
```
![撤销文件](/images/新建.netcore.png)

### 配置全局路由

修改 Startup.cs 文件
```
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
               //全局路由配置
                endpoints.MapControllerRoute(
　　　　        name:"default",
                pattern: "{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
```
# 启动


# 添加

# 删除

# 查询

