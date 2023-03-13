import pandas as pd
data=pd.read_csv("out.csv",encoding="shift-jis",index_col=0)
# print(data)
print(data.iloc[0:2,0:3])