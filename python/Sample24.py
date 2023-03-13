class Kata:
    def __init__(self,a):
        self.a = a
    def add(self):
        print("商品名は"+self.a+"です。")

name1 = Kata("あん")
name2 = Kata("クリーム")
print(name1.add())
print(name2.add())