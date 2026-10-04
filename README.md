# 1151VR-HW2

## 作業名稱
Unity 2D 人物移動實作

---

## 一、作業內容

本次作業使用 Unity 建立一個 2D 專案，並匯入 2D 人物圖片與森林背景。

透過 C# 程式控制人物在畫面中移動，人物會從森林右側開始，往左側移動，途中經過不同的位置，並利用座標變化呈現前進、跳躍、下降以及移動到終點的效果。

另外加入人物大小改變的效果，讓人物從森林較遠的位置移動到前方時逐漸放大，增加畫面的距離感與層次感。

本作業使用 Vector2 與陣列來控制人物移動路徑。

---

## 二、使用工具

- Unity 6
- C#
- Visual Studio
- GitHub
- GitHub Desktop
- YouTube

---

## 三、使用功能

本次作業主要使用以下 Unity 與 C# 功能：

- Unity 2D Project
- Sprite
- Sprite Renderer
- C# Script
- Vector2
- Array 陣列
- Start()
- Update()
- Vector2.MoveTowards()
- Time.deltaTime
- transform.position
- transform.localScale
- Vector3.Lerp()
- SpriteRenderer.flipX

---

## 四、製作流程

### 1. 建立 Unity 2D 專案

首先使用 Unity Hub 建立新的 2D 專案。

建立完成後進入 Unity Editor，確認場景中包含 Main Camera 與 2D 相關設定。

---

### 2. 匯入人物圖片

將人物 PNG 圖片匯入 Unity 的 Assets 資料夾。

在 Inspector 中設定：

- Texture Type：Sprite (2D and UI)
- Sprite Mode：Single

完成後按下 Apply。

接著將人物圖片拖曳到 Scene 中，建立人物 GameObject。

---

### 3. 匯入森林背景

將森林背景圖片匯入 Assets。

同樣將圖片設定為：

- Texture Type：Sprite (2D and UI)
- Sprite Mode：Single

完成後將背景圖片拖到 Scene 中。

為了避免背景擋住人物，在背景的 Sprite Renderer 中將：

```text
Order in Layer
