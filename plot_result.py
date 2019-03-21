import matplotlib.pyplot as plt
import numpy as np

name = '2d_binom_2q'

path = 'data_' + name + ".txt" # "data_2_peak_binom_far.txt" # "data_2_peak_binom_close.txt"
# Sometimes things go wrong 

colors = ['b', 'r', 'g', 'k', 'c', 'm']

logic = [0, 0, 0, 1] # [5, 4, 4, 5, 5, 0, 0, 2, 2, 2, 3, 3, 3, 1, 1] # [1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 0] # [1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0]
arr = np.loadtxt(path, delimiter=';')
if len(arr.shape) == 1 or arr.shape[0] == 1:
    arr = np.insert(arr, 1, 1, axis=1)

nums = {}
zeros = []
ones = []
for idx, i in enumerate(logic):
    if i not in nums.keys():
        nums[i] = []
    nums[i].append(arr[idx])

for i in nums.keys():
    nums[i] = np.array(nums[i])

for ik, k in nums.items():
    plt.plot(k[:, 0], k[:, 1], color=colors[ik % len(colors)], marker='.', linestyle='')
plt.xlim((-3, 3))
plt.ylim((-3, 3))
plt.title(name)
plt.savefig('result_' + name)
plt.show()

