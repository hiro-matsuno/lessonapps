import pandas as pd

data = {
    "名前":["岡田","山田","吉田","松田","藤田"],
    "身長":[162,180,172,150,173],
    "体重":[55,80,72,50,76],
    "年齢":[20,50,32,21,44]
}

df=pd.DataFrame(data,columns=["名前","身長","体重","年齢"])
df.to_csv('out.csv',encoding='shift-jis')