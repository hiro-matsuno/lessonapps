%matplotlob inline
import matplotlib.pyplot as plt
import numpy as np
x = np.array([2014,2015,2016,2017,2018,2019,2020,2021])
y = np.array([200,300,400,400,450,420,500,510])
plt.title("Year and Count")
plt.xlabel("Year")
plt.ylabel("Count")
plt.grid(False)
plt.plot(x,y)