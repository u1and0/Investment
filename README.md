<<自己紹介>>

iMacrosで動作する.iimファイル郡

(1)volatility.iim---ボラティリティのページへ行きをデイリー順に並べる

(2)import_calendar.iim---経済指標カレンダーの自動登録

(3)screening.iim---押し目買い銘柄を株価をチャートの形から搾り出す

(4)zaimu.iim---screening.iimの後に使用。会社のデータを抜き出してcsvに保存。ループでタブを変えながら行う。

(5)virtual_porforio_input_page1_2.iim---zaimu.iimの後に使用。yahooポートフォリオの銘柄登録画面へ行く。

(6)virtual_porforio_input_page2.iim---100株を今日の日にちで買ったことにする入力を行う。ループ処理可能。

(7)getcsvvola.vb---volatility.iimで取得したcsvをexcelにコピペ



<<改造予定>>

(1)volatility.iim
- txtだかcsvだかに定期的に保存していく。
- ソートはExcel上で行うか。値を取得するには順番どおりとは行かないようだ。
- あるいはソートはperlで・・・しかし面倒くさい
- Excelで開いたときパーセンテージで色分けされていればいいのだ
- 定期保存の方法はうまくいきそうだが、csvで保存してgnuplotでグラフ化するか、excelでグラフ表示？excelの棒グラフ見づらいんだよナァ

(2)  
なし


(3)screening.iim  
搾り出した後に表をコピーしていつも入力しているxlsxファイルに登録したいのだが、HTMLどうなっていてどうやって取得するのかわからん

(4)zaimu.iim  
売り買い割高割安をフォームから取得してきていつも入力しているxlsxファイルに登録したいのだが、HTMLどうなっていてどうやって取得するのかわからん

(5)virtual_porforio_input_page1_2.iim  
zaimuで抜き出したcsvから番号抜き出してきてフォームに入力する。

(6)virtual_porforio_input_page2.iim  
zaimuで抜き出したcsvからその日の終値を取得してきてフォームに入力する。
