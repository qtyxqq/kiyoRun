🧰 一、你需要准备的软件（必须）
✅ 1. Unity Hub

👉 下载：
https://unity.com/download

作用：

管理Unity版本
创建项目
✅ 2. Unity（建议版本）

安装时选：

Unity 2022 LTS（稳定）

⚠️ 安装时一定勾选：

✅ iOS Build Support
✅ Mac Build Support（如果你用Mac）
🍎 3. Xcode（必须）

👉 Mac App Store下载

作用：

把Unity项目变成iPhone App
安装到手机

⚠️ 必须是Mac（Windows做不了这一步）

🍎 4. Apple账号（重要）
免费账号也可以
用来签名App
🖥 二、创建Unity项目（第一次）
1️⃣ 打开 Unity Hub

👉 New Project

选择：

2D Core

命名：

ChibiRunner
2️⃣ 进入项目后做基础设置
📱 设置分辨率（适配手机）

菜单：

Edit → Project Settings → Player

设置：

Orientation：Landscape（横版）
🎮 三、导入你的游戏内容
1️⃣ 导入图片

把这些拖进去：

角色Q版图
怪物
金币
攻击特效
2️⃣ 创建场景

Hierarchy 右键：

Create Empty（地面）
创建 Player（你的角色）
3️⃣ 挂脚本（用我给你的代码）

把Canvas里的代码：

👉 分成几个 .cs 文件：

PlayerController.cs
PlayerAttack.cs
EnemyAI.cs
Boss.cs
UIManager.cs

👉 拖到对应对象上

📱 四、设置iPhone运行（最关键）
1️⃣ 切换平台

菜单：

File → Build Settings

选择：
👉 iOS → Switch Platform

2️⃣ 连接你的iPhone

用数据线连接

打开：
👉 Xcode → Window → Devices
确认手机被识别

3️⃣ Unity里点击 Build

选择一个文件夹（比如 Desktop）

👉 会生成一个 Xcode 项目

🍎 五、用Xcode安装到手机
1️⃣ 打开项目

双击：

Unity生成的 .xcodeproj
2️⃣ 设置签名（最重要一步）

在 Xcode：

选中项目（左侧最上面）
Signing & Capabilities

设置：

Team：选你的Apple账号

👉 如果没有：

添加 Apple ID
3️⃣ 选择你的手机

顶部设备选择：
👉 你的 iPhone

4️⃣ 点击运行 ▶️

👉 App会自动安装到你手机

⚠️ 常见坑（我帮你提前踩了）
❌ 问题1：手机打不开App

解决：
👉 设置 → 通用 → VPN与设备管理
→ 信任开发者

❌ 问题2：Unity没有iOS选项

👉 说明你安装Unity时没勾 iOS模块
→ 回Unity Hub补装

❌ 问题3：Build失败

👉 90%是Xcode没装好 or 版本问题

🎯 最终效果（你能做到）

完成后你可以：

📱 在 iPhone 上玩你自己的游戏
🎮 跑、跳、打Boss全部能操作
🚀 下一步可以直接上架