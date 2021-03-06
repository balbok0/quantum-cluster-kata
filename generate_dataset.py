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

# 2D two peak binomial
# 5 + 5 = 10 < 15/sqrt(2)
ax = np.multiply(-1, np.random.binomial(15, 7.0/15.0, 8))
ay = np.multiply(-1, np.random.binomial(15, 7.0/15.0, 8))
a = zip(ax, ay)
bx = np.random.binomial(15, 7.0/15.0, 8)
by = np.random.binomial(15, 7.0/15.0, 8)
b = zip(bx, by)

data = np.concatenate((a, b))
np.savetxt('data_2d_binom.txt', data, fmt='%d', delimiter=';')

# 2D two peak binomial
# 5 + 5 = 10 < 15/sqrt(2)
ax = np.multiply(-1, np.random.binomial(2, 7.0/15.0, 1))
ay = np.multiply(-1, np.random.binomial(2, 7.0/15.0, 1))
a = zip(ax, ay)
bx = np.random.binomial(2, 10.0/15.0, 3)
by = np.random.binomial(2, 10.0/15.0, 3)
b = zip(bx, by)

data = np.concatenate((a, b))
np.savetxt('data_2d_binom2q.txt', data, fmt='%d', delimiter=';')

# 2D three peak binomial
# 5 + 5 = 10 < 15/sqrt(2)
ax = np.multiply(-1, np.random.binomial(15, 7.0/15.0, 5))
ay = np.multiply(-1, np.random.binomial(15, 7.0/15.0, 5))
a = zip(ax, ay)
bx = np.random.binomial(15, 7.0/15.0, 5)
by = np.random.binomial(15, 7.0/15.0, 5)
b = zip(bx, by)
cx = np.random.binomial(15, 7.0/15.0, 5)
cy = np.multiply(-1, np.random.binomial(15, 7.0/15.0, 5))
c = zip(cx, cy)

data = np.concatenate((a, b, c))
np.savetxt('data_2d_3binom.txt', data, fmt='%d', delimiter=';')
