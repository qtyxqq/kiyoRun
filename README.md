# kiyoRun

一个基于 Unity 6000.4.0f1 开发的 2D 横版跑酷游戏项目，目标平台为 iPhone / iPad。  
当前项目处于原型开发阶段，重点是先跑通角色移动、跳跃、攻击、敌人交互、基础 UI 和协作开发流程。

---

## 1. 项目概况

项目名称：`kiyoRun`

项目类型：Unity 2D 横版跑酷

目标平台：
- iPhone
- iPad

当前 Unity 版本：
- `Unity 6000.4.0f1`

当前开发状态：
- 已有基础场景
- 已导入背景、地面、人物、敌人部分素材
- 已创建基础脚本
- 尚未完整跑通“移动 + 攻击 + 命中 + 动画 + 敌人死亡”的闭环
- 正在进入双人协作开发阶段

---

## 2. 当前已实现内容

### 已有工程与场景
- Unity 工程已创建
- 基础场景 `SampleScene` 已存在
- 已有对象：
  - Background
  - Ground
  - Player
  - Enemy
  - Camera

### 已有脚本
- `PlayerController.cs`
- `PlayerAttack.cs`
- `EnemyAI.cs`
- `Boss.cs`
- `AttackHitbox.cs`
- `CameraFollow.cs`（如已加入）

### 已有方向
- 跑步
- 跳跃
- 二段跳
- 长按高跳
- 攻击系统
- 普通敌人
- Boss 预留
- 血量 / 金币 / 分数系统规划中

---

## 3. 当前主要问题

当前工程还没有完全跑通，主要问题如下：

### 素材问题
- Player、Enemy 素材不是标准透明 PNG
- 角色素材存在白底，影响显示效果
- 动画素材不完整
- 部分素材只是参考图，还不是可直接用于 Unity 动画的资源

### 场景问题
- Background、Ground、Player、Enemy 的图层关系需要统一
- 部分对象位置、缩放、碰撞盒尚未标准化
- Ground 结构还没有规范成真正可扩展的关卡地块

### 功能问题
- 攻击动画还没有完整跑通
- 攻击动作、Hitbox、敌人受击/死亡之间尚未完全联动
- 角色移动与动画状态切换未完全闭环
- Camera 跟随、场景滚动、UI 显示仍需继续完善

### 协作问题
- 仓库刚开始搭建，尚未建立完整协作规则
- 需要统一分支开发规范和提交规范
- 新协作者需要先完成环境搭建

---

## 4. TODO LIST

## P0：必须优先完成（先跑通原型）

- [ ] 修复所有编译错误与 Console 红字
- [ ] 统一 Input 设置，保证当前输入逻辑能正常运行
- [ ] 检查 Player、Enemy、Ground、Background 的组件挂载是否完整
- [ ] 统一 Sorting Layer 和 Order in Layer，确保角色显示在背景和地面前面
- [ ] 把 Player 素材替换为透明 PNG
- [ ] 把 Enemy 素材替换为透明 PNG
- [ ] 把攻击特效素材替换为透明 PNG
- [ ] 修正 Player 的碰撞盒大小和位置
- [ ] 修正 Enemy 的碰撞盒大小和位置
- [ ] 跑通 Player 自动前进
- [ ] 跑通点击跳跃
- [ ] 跑通二段跳
- [ ] 跑通长按高跳
- [ ] 跑通攻击按钮 / 测试按键触发攻击
- [ ] 跑通攻击动画播放
- [ ] 跑通攻击时生成 Hitbox
- [ ] 跑通 Hitbox 命中 Enemy
- [ ] 跑通 Enemy 死亡逻辑
- [ ] 跑通 Camera 跟随 Player
- [ ] 让整个场景第一次实现“可进入游戏并完整玩一轮”的闭环

## P1：原型完善

- [ ] 给 Player 建立 Animator Controller
- [ ] 完成跑步动画
- [ ] 完成跳跃动画
- [ ] 完成攻击动画
- [ ] 完成 Enemy 基础移动动画
- [ ] 完成 Enemy 受击 / 死亡动画
- [ ] 增加基础 HP 显示
- [ ] 增加 Coin 显示
- [ ] 增加 Score 显示
- [ ] 增加攻击按钮 UI
- [ ] 增加减速按钮 UI
- [ ] 让 UI 能正确调用 Player 行为
- [ ] 增加 GameManager 管理分数 / 金币 / 状态
- [ ] 增加 EnemySpawner
- [ ] 增加地面拼接与障碍布局

## P2：后续扩展

- [ ] Boss 场景接入
- [ ] Boss 行为逻辑
- [ ] Boss 受击与死亡
- [ ] 金币拾取逻辑
- [ ] 分数累计逻辑
- [ ] 场景结算逻辑
- [ ] iOS 真机测试
- [ ] iOS 构建流程整理
- [ ] 音效与背景音乐
- [ ] 关卡结构优化

---

## 5. 建议目录结构

```text
Assets
├── Art
│   ├── Background
│   ├── Ground
│   ├── Player
│   ├── Enemy
│   ├── Boss
│   ├── Effects
│   └── UI
├── Animations
├── Prefabs
├── Scenes
├── Scripts
└── Settings
