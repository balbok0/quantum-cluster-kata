import matplotlib.pyplot as plt
import numpy as np

path = "data_2d_binom.txt" # "data_2_peak_binom_far.txt" # "data_2_peak_binom_close.txt"
# Sometimes things go wrong 

logic = [1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 0] # [1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0] # [1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0]
arr = np.loadtxt(path, delimiter=';')

zeros = []
ones = []
for idx, i in enumerate(logic):
    if i == 0:
        zeros.append(arr[idx])
    else:
        ones.append(arr[idx])
ones = np.array(ones)
zeros = np.array(zeros)
print(ones)
plt.plot(ones[:, 0], ones[:, 1], color='b', marker='.', linestyle='')
plt.plot(zeros[:, 0], zeros[:, 1], color='r', marker='.', linestyle='')

plt.show()
