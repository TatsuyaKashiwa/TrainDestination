# TrainDestination
 - 列車の行先表示を模したもので、種別と行先を記した画像ファイルを読み込みフォームに表示させます。

## はじめに
- openclassific/opendestinationの各コンポーネントのInitialDirectryに  
  プロジェクト内にあるclassification/destinationディレクトリの絶対パスを入力します。

## 画面
- 帯  
  画面最上部にある列車の帯を模したものです。  
  後述の帯色変更ボタンで色を変更させられます。
- 表示部分  
  帯の下の領域です  
  種別画像 行先画像 の順に表示されます  
- 窓部分  
  帯の下にある列車の窓を模したものです  
  表示は水色の長方形で固定となります。  
- ボタン部分  
   - 種別表示  
     ファイル選択ダイアログが開き種別画像を選択します。  
     選択した画像が表示部分の左側に表示されます。
   - 行先表示  
     ファイル選択ダイアログが開き行先画像を選択します。  
     選択した画像が表示部分の右側に表示されます。
   - 帯色変更  
     色ダイアログが開き、帯が選択した色に変更できます。
   - 表示取消  
     種別画像・行先画像の表示を取り消して初期状態に戻します  
     (帯色変更による帯色の変更はそのままとなります)
   - 閉じる  
     このプログラムを閉じます
     (ESCボタンでも閉じることは可能です)
