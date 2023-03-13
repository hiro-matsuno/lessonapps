class Kata:
    def __init__(self,a):
        self.a = a
    def add(self):
        print("商品名は"+self.a+"です。")
class Kata2(Kata):
    def __init__(self,a):
        super().__init__(a)

    def add2(self):
        print(self.a+"が追加されました。")

name3 = Kata2("チョコ")
name3.add2()