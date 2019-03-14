import numpy as np

# Two binomial datapoints - far away
a = np.random.binomial(15, 2.0/15.0, 8)
b = np.random.binomial(15, 12.0/15.0, 8)

data = np.concatenate((a, b))
np.savetxt('data_2_peak_binom_far.txt', data, fmt='%d', delimiter=';')

# Two binomial datapoints - close by
a = np.random.binomial(15, 5.0/15.0, 8)
b = np.random.binomial(15, 8.0/15.0, 8)

data = np.concatenate((a, b))
np.savetxt('data_2_peak_binom_close.txt', data, fmt='%d', delimiter=';')

# Geometric datapoints - far away
a = np.random.geometric(1.5/15.0, 8)
b = np.random.geometric(5.0/15.0, 8)
a[a > 15] = 15
b[b > 15] = 15

data = np.concatenate((a, b))
np.savetxt('data_geom_far.txt', data, fmt='%d', delimiter=';')
