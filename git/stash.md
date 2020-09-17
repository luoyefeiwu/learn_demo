1. statsh
```
git stash list 查看所有暂存
```
![暂存修改](/images/暂存修改.png)

2. git statsh save '测试修改'

![暂存修改](/images/测试暂存修改.png)

3. 查看该文件

![暂存修改](/images/查看测试暂存修改.png)

4. 指定恢复
```
 git stash pop stash@{num}
```

![暂存修改](/images/指定恢复.png)


5. 删除stash
```
git stash drop stash@{num}
```