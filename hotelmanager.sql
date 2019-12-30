/*
 Navicat MySQL Data Transfer

 Source Server         : mysql
 Source Server Type    : MySQL
 Source Server Version : 80015
 Source Host           : localhost:3306
 Source Schema         : hotelmanager

 Target Server Type    : MySQL
 Target Server Version : 80015
 File Encoding         : 65001

 Date: 25/12/2019 14:23:16
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for fonts
-- ----------------------------
DROP TABLE IF EXISTS `fonts`;
CREATE TABLE `fonts`  (
  `FontsId` int(11) NOT NULL,
  `FontsMess` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`FontsId`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of fonts
-- ----------------------------
INSERT INTO `fonts` VALUES (0, 'Author：姜文昊');
INSERT INTO `fonts` VALUES (1, '合作者：王家丰');

-- ----------------------------
-- Table structure for login
-- ----------------------------
DROP TABLE IF EXISTS `login`;
CREATE TABLE `login`  (
  `username` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `password` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of login
-- ----------------------------
INSERT INTO `login` VALUES ('admin', '1111');

-- ----------------------------
-- Table structure for operationlog
-- ----------------------------
DROP TABLE IF EXISTS `operationlog`;
CREATE TABLE `operationlog`  (
  `OperationId` int(11) NOT NULL AUTO_INCREMENT,
  `OperationTime` datetime(6) NOT NULL,
  `Operationlog` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `OperationAccount` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  PRIMARY KEY (`OperationId`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 223 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of operationlog
-- ----------------------------
INSERT INTO `operationlog` VALUES (222, '2019-12-25 14:08:22.000000', '于2019/12/25 14:08:22登入了系统！', 'admin');
INSERT INTO `operationlog` VALUES (223, '2019-12-25 14:11:56.000000', '于2019/12/25 14:11:56登入了系统！', 'admin');

-- ----------------------------
-- Table structure for passporttype
-- ----------------------------
DROP TABLE IF EXISTS `passporttype`;
CREATE TABLE `passporttype`  (
  `PassportId` int(11) NOT NULL,
  `PassportName` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`PassportId`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of passporttype
-- ----------------------------
INSERT INTO `passporttype` VALUES (0, '中国居民身份证');
INSERT INTO `passporttype` VALUES (1, '港澳通行证');
INSERT INTO `passporttype` VALUES (2, '台胞证');
INSERT INTO `passporttype` VALUES (3, '军官证');
INSERT INTO `passporttype` VALUES (4, '外国护照');

-- ----------------------------
-- Table structure for reser
-- ----------------------------
DROP TABLE IF EXISTS `reser`;
CREATE TABLE `reser`  (
  `ReserId` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `CustoName` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `CustoTel` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `ReserWay` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `ReserRoom` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `ReserCash` decimal(65, 2) NOT NULL,
  `ReserDate` datetime(6) NOT NULL,
  `ReserPerson` int(255) NOT NULL,
  PRIMARY KEY (`ReserId`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of reser
-- ----------------------------
INSERT INTO `reser` VALUES ('rs0001', '王家丰', '110', '互联网', '情侣套房', 388.00, '2019-12-14 13:30:41.000000', 2);
INSERT INTO `reser` VALUES ('rs0002', '姜文昊', '10086', '手机客户端', '总统套房', 688.00, '2019-12-16 13:30:41.000000', 1);
INSERT INTO `reser` VALUES ('rs10001', '张三疯', '10010', '电话', '标准单人间', 1088.00, '2019-12-18 23:04:40.000000', 1);

-- ----------------------------
-- Table structure for room
-- ----------------------------
DROP TABLE IF EXISTS `room`;
CREATE TABLE `room`  (
  `RoomNo` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `RoomType` int(255) NOT NULL,
  `CustoNo` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `CheckTime` datetime(0) NULL DEFAULT NULL,
  `CheckOutTime` datetime(0) NULL DEFAULT NULL,
  `RoomStateId` int(11) NOT NULL,
  `RoomMoney` decimal(65, 2) NOT NULL,
  `PersonNum` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `RoomPosition` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  PRIMARY KEY (`RoomNo`) USING BTREE,
  INDEX `RoomType`(`RoomType`) USING BTREE,
  INDEX `RoomStateId`(`RoomStateId`) USING BTREE,
  CONSTRAINT `room_ibfk_1` FOREIGN KEY (`RoomType`) REFERENCES `roomtype` (`Roomtype`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `room_ibfk_2` FOREIGN KEY (`RoomStateId`) REFERENCES `roomstate` (`RoomStateId`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of room
-- ----------------------------
INSERT INTO `room` VALUES ('BD001', 0, NULL, NULL, NULL, 0, 300.00, NULL, 'A层');
INSERT INTO `room` VALUES ('BD002', 0, NULL, NULL, NULL, 0, 300.00, NULL, 'A层');
INSERT INTO `room` VALUES ('BD003', 0, NULL, NULL, '2019-12-17 23:48:08', 0, 300.00, NULL, 'A层');
INSERT INTO `room` VALUES ('BD004', 0, NULL, NULL, NULL, 0, 300.00, NULL, 'A层');
INSERT INTO `room` VALUES ('BD005', 0, NULL, NULL, '2019-12-17 21:05:30', 0, 300.00, NULL, 'A层');
INSERT INTO `room` VALUES ('BD006', 0, NULL, NULL, '2019-12-17 23:48:26', 0, 300.00, NULL, 'A层');
INSERT INTO `room` VALUES ('BD007', 0, NULL, NULL, NULL, 0, 300.00, NULL, 'A层');
INSERT INTO `room` VALUES ('BD008', 0, NULL, NULL, '2019-12-13 08:34:31', 0, 300.00, NULL, 'A层');
INSERT INTO `room` VALUES ('BS001', 1, NULL, NULL, NULL, 0, 425.00, NULL, 'A层');
INSERT INTO `room` VALUES ('BS002', 1, NULL, NULL, NULL, 0, 425.00, NULL, 'A层');
INSERT INTO `room` VALUES ('BS003', 1, NULL, NULL, NULL, 0, 425.00, NULL, 'A层');
INSERT INTO `room` VALUES ('BS004', 1, NULL, NULL, '2019-12-18 23:07:57', 0, 425.00, NULL, 'A层');
INSERT INTO `room` VALUES ('BS005', 1, NULL, NULL, NULL, 0, 425.00, NULL, 'A层');
INSERT INTO `room` VALUES ('BS006', 1, NULL, NULL, NULL, 0, 425.00, NULL, 'A层');
INSERT INTO `room` VALUES ('HD001', 2, NULL, NULL, NULL, 0, 625.00, NULL, 'B层');
INSERT INTO `room` VALUES ('HD002', 2, NULL, NULL, '2019-12-17 17:36:58', 0, 625.00, NULL, 'B层');
INSERT INTO `room` VALUES ('HD003', 2, NULL, NULL, NULL, 0, 625.00, NULL, 'B层');
INSERT INTO `room` VALUES ('HD004', 2, NULL, NULL, NULL, 0, 625.00, NULL, 'B层');
INSERT INTO `room` VALUES ('HD005', 2, NULL, NULL, NULL, 0, 625.00, NULL, 'B层');
INSERT INTO `room` VALUES ('HS001', 0, NULL, NULL, NULL, 0, 600.00, NULL, 'B层');
INSERT INTO `room` VALUES ('HS002', 3, NULL, NULL, NULL, 0, 660.00, NULL, 'B层');
INSERT INTO `room` VALUES ('HS003', 3, NULL, NULL, NULL, 0, 660.00, NULL, 'B层');
INSERT INTO `room` VALUES ('HS004', 3, NULL, NULL, NULL, 0, 660.00, NULL, 'B层');
INSERT INTO `room` VALUES ('HS005', 3, NULL, NULL, NULL, 0, 660.00, NULL, 'B层');
INSERT INTO `room` VALUES ('HS006', 3, NULL, NULL, NULL, 0, 660.00, NULL, 'B层');
INSERT INTO `room` VALUES ('QL001', 4, NULL, NULL, NULL, 0, 845.00, NULL, 'C层');
INSERT INTO `room` VALUES ('QL002', 4, NULL, NULL, NULL, 0, 845.00, NULL, 'C层');
INSERT INTO `room` VALUES ('QL003', 4, NULL, NULL, NULL, 0, 845.00, NULL, 'C层');
INSERT INTO `room` VALUES ('ZT001', 5, NULL, NULL, NULL, 0, 2080.00, NULL, 'D层');
INSERT INTO `room` VALUES ('ZT002', 5, NULL, NULL, '2019-12-25 14:05:52', 2, 2080.00, NULL, 'D层');
INSERT INTO `room` VALUES ('ZT003', 5, NULL, NULL, NULL, 0, 2080.00, NULL, 'D层');

-- ----------------------------
-- Table structure for roomstate
-- ----------------------------
DROP TABLE IF EXISTS `roomstate`;
CREATE TABLE `roomstate`  (
  `RoomStateId` int(11) NOT NULL,
  `RoomState` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`RoomStateId`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of roomstate
-- ----------------------------
INSERT INTO `roomstate` VALUES (0, '可住房');
INSERT INTO `roomstate` VALUES (1, '已住房');
INSERT INTO `roomstate` VALUES (2, '维修中');
INSERT INTO `roomstate` VALUES (3, '脏房');

-- ----------------------------
-- Table structure for roomtype
-- ----------------------------
DROP TABLE IF EXISTS `roomtype`;
CREATE TABLE `roomtype`  (
  `Roomtype` int(11) NOT NULL,
  `RoomName` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`Roomtype`) USING BTREE,
  INDEX `RoomName`(`RoomName`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of roomtype
-- ----------------------------
INSERT INTO `roomtype` VALUES (5, '总统套房');
INSERT INTO `roomtype` VALUES (4, '情侣套房');
INSERT INTO `roomtype` VALUES (0, '标准单人间');
INSERT INTO `roomtype` VALUES (1, '标准双人间');
INSERT INTO `roomtype` VALUES (2, '豪华单人间');
INSERT INTO `roomtype` VALUES (3, '豪华双人间');

-- ----------------------------
-- Table structure for spend
-- ----------------------------
DROP TABLE IF EXISTS `spend`;
CREATE TABLE `spend`  (
  `SpendId` int(11) NOT NULL AUTO_INCREMENT,
  `RoomNo` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `CustoNo` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `RoomName` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `SpendPrice` decimal(10, 2) NOT NULL,
  `SpendMoney` decimal(10, 0) NOT NULL,
  `SpendTime` datetime(0) NOT NULL,
  `MoneyState` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  PRIMARY KEY (`SpendId`) USING BTREE,
  INDEX `RoomNo`(`RoomNo`) USING BTREE,
  INDEX `CustoNo`(`CustoNo`) USING BTREE,
  INDEX `RoomName`(`RoomName`) USING BTREE,
  CONSTRAINT `spend_ibfk_1` FOREIGN KEY (`RoomNo`) REFERENCES `room` (`RoomNo`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `spend_ibfk_2` FOREIGN KEY (`CustoNo`) REFERENCES `userinfo` (`CustoNo`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `spend_ibfk_3` FOREIGN KEY (`RoomName`) REFERENCES `roomtype` (`RoomName`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 7 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of spend
-- ----------------------------
INSERT INTO `spend` VALUES (2, 'BD005', 'TS1003', '标准单人间', 300.00, 1500, '2019-12-17 21:04:48', '已结算');
INSERT INTO `spend` VALUES (3, 'BD003', 'TS1002', '标准单人间', 300.00, 1500, '2019-12-17 22:14:01', '已结算');
INSERT INTO `spend` VALUES (4, 'BD006', 'TS1003', '标准单人间', 300.00, 300, '2019-12-17 23:47:18', '已结算');
INSERT INTO `spend` VALUES (5, 'BS004', 'TS1084', '标准双人间', 425.00, 850, '2019-12-18 23:07:44', '已结算');
INSERT INTO `spend` VALUES (6, 'ZT002', 'TS1005', '总统套房', 2080.00, 4160, '2019-12-25 14:04:59', '已结算');

-- ----------------------------
-- Table structure for userinfo
-- ----------------------------
DROP TABLE IF EXISTS `userinfo`;
CREATE TABLE `userinfo`  (
  `CustoNo` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `CustoName` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `CustoSex` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `CustoTel` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `PassportType` int(11) NOT NULL,
  `CustoID` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `CustoAdress` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `CustoBirth` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `CustoType` int(11) NOT NULL,
  PRIMARY KEY (`CustoNo`) USING BTREE,
  INDEX `PassportType`(`PassportType`) USING BTREE,
  INDEX `CustoType`(`CustoType`) USING BTREE,
  CONSTRAINT `userinfo_ibfk_1` FOREIGN KEY (`PassportType`) REFERENCES `passporttype` (`PassportId`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `userinfo_ibfk_2` FOREIGN KEY (`CustoType`) REFERENCES `usertype` (`UserType`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of userinfo
-- ----------------------------
INSERT INTO `userinfo` VALUES ('TS1001', '杨俊杰', '男', '12345678901', 0, '440921199907205754', '', '1900-01-01 00:00:00.000', 2);
INSERT INTO `userinfo` VALUES ('TS1002', '熊越明', '男', '12345678901', 0, '9999-8888-7777-6666', '', '1997-09-23 00:00:00.000', 1);
INSERT INTO `userinfo` VALUES ('TS1003', '宾华安', '男', '13075612081', 0, '440982200007035911', '', '1900-01-01 00:00:00.000', 1);
INSERT INTO `userinfo` VALUES ('TS1005', 'Billy Hank', '男', '1231231213', 4, '003-12312312222222', 'American SHENGDIYAGE', '1900-01-01 18:19:00.000', 3);
INSERT INTO `userinfo` VALUES ('TS1084', '景晨', '男', '13902992233', 1, '363939877421', '', '1998-02-17 15:40:04.000', 0);
INSERT INTO `userinfo` VALUES ('TS1266', '小舞', '女', '2222222', 0, '2222222222222', '', '1998-12-03 11:49:45.000', 0);
INSERT INTO `userinfo` VALUES ('TS1301', '蔡徐坤', '女', '777777', 4, '88888888888888', '', '1996/2/22 23:05:53', 1);
INSERT INTO `userinfo` VALUES ('TS1628', '姜文昊', '男', '110', 0, '8008208820', '北京交通大学海滨学院', '15:40', 0);
INSERT INTO `userinfo` VALUES ('TS1816', '李顺', '男', '15217186471', 0, '123456789012345678', '天堂度假村', '1906-02-03 18:19:00.000', 1);

-- ----------------------------
-- Table structure for usertype
-- ----------------------------
DROP TABLE IF EXISTS `usertype`;
CREATE TABLE `usertype`  (
  `UserType` int(11) NOT NULL,
  `TypeName` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`UserType`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of usertype
-- ----------------------------
INSERT INTO `usertype` VALUES (0, '普通用户');
INSERT INTO `usertype` VALUES (1, '钻石会员');
INSERT INTO `usertype` VALUES (2, '白金会员');
INSERT INTO `usertype` VALUES (3, '黄金会员');

SET FOREIGN_KEY_CHECKS = 1;
