## 江湖十一 窗口化 小工具 + 分辨率修改

下载地址： https://mod.3dmgame.com/mod/192783

游戏目前不能窗口化，有点小难受；  
简单写了个小工具，让游戏可以窗口化游玩；  

### 所需前置
- [BepInEx](https://mod.3dmgame.com/mod/172563)
- [BepInEx.ConfigurationManager](https://github.com/BepInEx/BepInEx.ConfigurationManager/releases) (可选)

### 使用方法
- 下载安装 BepInEx
- 下载安装 BepInEx.ConfigurationManager
- 下载Mod
- 将`JH11_windowed.dll`文件解压到`BepInEx\plugins`目录
- 如果没有plugins目录就自己新建一个
- 进游戏就直接是窗口化了

### 修改分辨率
- 如果你装了 BepInEx.ConfigurationManager ，进游戏按F1 可以看到窗口相关配置
- 如果你没装，那么运行一次游戏，然后就可以找到一个 `\BepInEx\config\aoe.top.plugins.JH11_windowed.cfg`文件
- 在这里修改分辨率，格式为 `_宽x高`， 中间没有空格,前面的`_`可有可无
> `Acceptable values`里面是枚举的值

### 已知问题
- 在切换窗口的时候会有闪屏


