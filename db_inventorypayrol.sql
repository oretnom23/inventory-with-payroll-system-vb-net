-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 22, 2019 at 06:26 AM
-- Server version: 10.1.36-MariaDB
-- PHP Version: 5.6.38

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_inventorypayrol`
--

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `emp_code` varchar(30) NOT NULL,
  `emp_fname` varchar(60) DEFAULT NULL,
  `emp_lname` varchar(60) DEFAULT NULL,
  `emp_mname` varchar(60) DEFAULT NULL,
  `address` varchar(100) DEFAULT NULL,
  `contact` int(20) DEFAULT NULL,
  `status` varchar(30) DEFAULT NULL,
  `birth_date` date DEFAULT NULL,
  `birth_place` varchar(100) DEFAULT NULL,
  `emp_sex` varchar(10) DEFAULT NULL,
  `emp_age` int(10) DEFAULT NULL,
  `emerg_contct` int(25) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`emp_code`, `emp_fname`, `emp_lname`, `emp_mname`, `address`, `contact`, `status`, `birth_date`, `birth_place`, `emp_sex`, `emp_age`, `emerg_contct`) VALUES
('123123', 'janoo', 'pad', 'sad', 'asd', 1233123, '----Select-----', '1990-02-22', 'sadasd', 'MALE', 27, 1233123);

-- --------------------------------------------------------

--
-- Table structure for table `employee_workinfo`
--

CREATE TABLE `employee_workinfo` (
  `id` int(10) NOT NULL,
  `emp_code` varchar(10) NOT NULL,
  `d_rate` int(30) DEFAULT NULL,
  `p_method` varchar(60) DEFAULT NULL,
  `position` varchar(60) DEFAULT NULL,
  `w_status` varchar(60) DEFAULT NULL,
  `d_hired` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `employee_workinfo`
--

INSERT INTO `employee_workinfo` (`id`, `emp_code`, `d_rate`, `p_method`, `position`, `w_status`, `d_hired`) VALUES
(26, '123123', 323, 'Weekly', 'clerk', 'Active', '2014-11-27');

-- --------------------------------------------------------

--
-- Table structure for table `other_deduction`
--

CREATE TABLE `other_deduction` (
  `KEY` int(11) NOT NULL,
  `trans_id` varchar(30) NOT NULL,
  `emp_code` varchar(10) DEFAULT NULL,
  `deduct1` varchar(60) DEFAULT NULL,
  `ded_amount1` int(30) DEFAULT NULL,
  `deduct2` varchar(60) DEFAULT NULL,
  `ded_amount2` int(30) DEFAULT NULL,
  `deduct3` varchar(60) DEFAULT NULL,
  `ded_amount3` int(30) DEFAULT NULL,
  `deduct4` varchar(60) DEFAULT NULL,
  `ded_amount4` int(30) DEFAULT NULL,
  `total_ded` int(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `other_deduction`
--

INSERT INTO `other_deduction` (`KEY`, `trans_id`, `emp_code`, `deduct1`, `ded_amount1`, `deduct2`, `ded_amount2`, `deduct3`, `ded_amount3`, `deduct4`, `ded_amount4`, `total_ded`) VALUES
(15, '3230248', '123123', 'd1', 2, 'd2', 2, 'd3', 0, 'd4', 0, 16);

-- --------------------------------------------------------

--
-- Table structure for table `payroll`
--

CREATE TABLE `payroll` (
  `KEY` int(11) NOT NULL,
  `emp_code` varchar(10) NOT NULL,
  `num_days` int(30) DEFAULT NULL,
  `r_wage` int(30) DEFAULT NULL,
  `overtime` int(30) DEFAULT NULL,
  `hol_pay` int(30) DEFAULT NULL,
  `gross_sal` int(30) DEFAULT NULL,
  `cash_ad` int(30) DEFAULT NULL,
  `bread_vale` int(30) DEFAULT NULL,
  `philhealth` int(30) DEFAULT NULL,
  `pag-ibig` int(30) DEFAULT NULL,
  `net_income` int(30) DEFAULT NULL,
  `remarks` varchar(100) DEFAULT NULL,
  `dateissued` date NOT NULL,
  `trans_id` varchar(30) NOT NULL DEFAULT '0',
  `user_id` int(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `payroll`
--

INSERT INTO `payroll` (`KEY`, `emp_code`, `num_days`, `r_wage`, `overtime`, `hol_pay`, `gross_sal`, `cash_ad`, `bread_vale`, `philhealth`, `pag-ibig`, `net_income`, `remarks`, `dateissued`, `trans_id`, `user_id`) VALUES
(16, '123123', 15, 4845, 81, 646, 5572, 2, 2, 2, 2, 5556, 'sdadas', '2017-11-01', '3230248', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `tblautonumber`
--

CREATE TABLE `tblautonumber` (
  `ID` int(11) NOT NULL,
  `STRT` varchar(30) NOT NULL,
  `END` int(30) NOT NULL,
  `INCREMENT` int(11) NOT NULL,
  `DESCRIPTION` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblautonumber`
--

INSERT INTO `tblautonumber` (`ID`, `STRT`, `END`, `INCREMENT`, `DESCRIPTION`) VALUES
(1, '12201', 12, 1, 'Customer'),
(3, '20122', 8, 1, 'Suplier'),
(4, '32302', 49, 1, 'StockIn'),
(5, '49087', 38, 1, 'Stockout'),
(6, '53132', 18, 1, 'StockReturn'),
(7, '62030', 75, 1, 'Items'),
(13, 'P0000', 13, 1, 'Paint'),
(14, 'N0000', 4, 1, 'Nail');

-- --------------------------------------------------------

--
-- Table structure for table `tblitems`
--

CREATE TABLE `tblitems` (
  `ITEMID` varchar(11) NOT NULL,
  `NAME` varchar(90) NOT NULL,
  `DESCRIPTION` varchar(90) NOT NULL,
  `TYPE` varchar(30) NOT NULL,
  `PRICE` double NOT NULL,
  `QTY` int(11) NOT NULL,
  `UNIT` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblitems`
--

INSERT INTO `tblitems` (`ITEMID`, `NAME`, `DESCRIPTION`, `TYPE`, `PRICE`, `QTY`, `UNIT`) VALUES
('N00002', 'Umbrella', 'size 4', 'Nail', 4, 7, 'kilo'),
('N00003', 'Umbrella', 'size 2', 'Nail', 2, 5, 'kilo'),
('P00004', 'Boysen', 'Color Red, 700 ml', 'Paint', 500, 36, 'pcs.'),
('P00008', 'Enamel', 'color green, 1.5 liter', 'Paint', 450, 36, 'pcs.'),
('P00009', 'tttttttt', 'ggggggggggg', 'Paint', 1111, 4, 'pcs.');

-- --------------------------------------------------------

--
-- Table structure for table `tblperson`
--

CREATE TABLE `tblperson` (
  `ID` int(11) NOT NULL,
  `SUPLIERCUSTOMERID` varchar(90) DEFAULT NULL,
  `FIRSTNAME` varchar(90) DEFAULT NULL,
  `LASTNAME` varchar(90) DEFAULT NULL,
  `ADDRESS` varchar(90) DEFAULT NULL,
  `TELEPHONE` varchar(30) DEFAULT NULL,
  `MOBILE` varchar(30) DEFAULT NULL,
  `TYPE` varchar(90) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblperson`
--

INSERT INTO `tblperson` (`ID`, `SUPLIERCUSTOMERID`, `FIRSTNAME`, `LASTNAME`, `ADDRESS`, `TELEPHONE`, `MOBILE`, `TYPE`) VALUES
(3, '122018', 'James', 'Yap', 'Dancalan Ilog', '999-999-999', '095686586554', 'Customer'),
(4, '201224', 'jano', 'p', 'asadasdsadsadsaasdasdsaaasd', '23213', '232323', 'SUPLIER'),
(5, '1220111', 'Janry', 'Tan', 'Kabankalan city', '09356853264', '09356853264', 'Customer');

-- --------------------------------------------------------

--
-- Table structure for table `tblsettings`
--

CREATE TABLE `tblsettings` (
  `ID` int(11) NOT NULL,
  `DESCRIPTION` text NOT NULL,
  `PARA` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblsettings`
--

INSERT INTO `tblsettings` (`ID`, `DESCRIPTION`, `PARA`) VALUES
(1, 'Paint', 'Category'),
(2, 'pcs.', 'Unit'),
(3, 'Nail', 'Category'),
(4, 'kilo', 'Unit');

-- --------------------------------------------------------

--
-- Table structure for table `tblstock_in_out`
--

CREATE TABLE `tblstock_in_out` (
  `STOCKOUTID` int(11) NOT NULL,
  `TRANSACTIONNUMBER` varchar(30) NOT NULL,
  `ITEMID` varchar(30) NOT NULL,
  `TRANSACTIONDATE` date NOT NULL,
  `QTY` int(11) NOT NULL,
  `TOTALPRICE` double NOT NULL,
  `SUPLIERCUSTOMERID` varchar(30) NOT NULL,
  `REMARKS` varchar(30) NOT NULL,
  `OFFICIALRECEIPT` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblstock_in_out`
--

INSERT INTO `tblstock_in_out` (`STOCKOUTID`, `TRANSACTIONNUMBER`, `ITEMID`, `TRANSACTIONDATE`, `QTY`, `TOTALPRICE`, `SUPLIERCUSTOMERID`, `REMARKS`, `OFFICIALRECEIPT`) VALUES
(1, '3230235', 'P00003', '2015-02-24', 10, 500, '0000000', 'StockIn', ''),
(2, '3230236', 'N00001', '2015-02-24', 30, 1, '0000000', 'StockIn', ''),
(3, '3230237', 'P00004', '2015-02-24', 10, 500, '0000000', 'StockIn', ''),
(4, '3230238', 'P00005', '2015-02-24', 10, 500, '0000000', 'StockIn', ''),
(5, '3230239', 'P00004', '2015-02-24', 10, 500, '0000000', 'StockIn', ''),
(6, '3230240', 'P00004', '2015-02-24', 20, 500, '0000000', 'StockIn', ''),
(7, '4908726', 'P00004', '2015-02-24', 0, 500, '122018', 'StockOut', ''),
(8, '4908727', 'P00004', '2015-03-13', 2, 1000, '1220111', 'StockOut', 'lblreceipt'),
(9, '4908728', 'P00004', '2016-05-08', 2, 1000, '122018', 'StockOut', 'lblreceipt'),
(10, '3230241', 'N00002', '2016-05-08', 9, 4, '0000000', 'StockIn', ''),
(11, '3230242', 'N00003', '2016-05-08', 15, 2, '0000000', 'StockIn', ''),
(12, '3230243', 'P00008', '2016-05-08', 9, 450, '0000000', 'StockIn', ''),
(13, '4908729', 'P00008', '2016-05-08', 0, 0, '1220111', 'StockOut', 'lblreceipt'),
(14, '4908729', 'N00003', '2016-05-08', 6, 12, '1220111', 'StockOut', 'lblreceipt'),
(15, '4908731', 'N00003', '2016-07-23', 1, 2, '122018', 'StockOut', 'lblreceipt'),
(16, '4908732', 'N00002', '2016-08-05', 1, 4, '1220111', 'StockOut', 'lblreceipt'),
(17, '4908733', 'N00002', '2016-08-05', 1, 4, '1220111', 'StockOut', 'lblreceipt'),
(18, '4908734', 'N00003', '2016-08-05', 1, 2, '1220111', 'StockOut', 'lblreceipt'),
(19, '4908735', 'N00003', '2016-08-05', 1, 2, '122018', 'StockOut', 'lblreceipt'),
(20, '0', 'N00003', '2016-08-05', 1, 2, '122018', 'StockOut', '4908736'),
(21, '3230244', 'P00009', '2016-12-09', 4, 1111, '0000000', 'StockIn', ''),
(22, '4908737', 'P00009', '2016-12-09', 2, 2222, '122018', 'StockOut', 'lblreceipt'),
(23, '3230245', 'P00009', '2017-07-31', 2, 1111, '0000000', 'StockIn', ''),
(24, '3230246', 'P00008', '2017-08-01', 9, 450, '0000000', 'StockIn', ''),
(25, '3230247', 'P00008', '2017-10-16', 18, 450, '0000000', 'StockIn', '');

-- --------------------------------------------------------

--
-- Table structure for table `tblstock_return`
--

CREATE TABLE `tblstock_return` (
  `STOCKRETURNID` int(11) NOT NULL,
  `STOCKRETURNNUMBER` varchar(30) NOT NULL,
  `ITEMID` int(11) NOT NULL,
  `RETURNDATE` date NOT NULL,
  `QTY` int(11) NOT NULL,
  `TOTALPRICE` double NOT NULL,
  `OWNER_CUS_ID` int(11) NOT NULL,
  `r_REMARKS` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblstock_return`
--

INSERT INTO `tblstock_return` (`STOCKRETURNID`, `STOCKRETURNNUMBER`, `ITEMID`, `RETURNDATE`, `QTY`, `TOTALPRICE`, `OWNER_CUS_ID`, `r_REMARKS`) VALUES
(1, '5313214', 0, '2015-02-24', 1, 500, 122018, ''),
(2, '5313215', 0, '2015-02-25', 1, 500, 122018, ''),
(3, '5313216', 0, '2015-03-13', 1, 500, 122018, 'Defected'),
(4, '5313217', 0, '2016-07-14', 1, 450, 1220111, 'guba');

-- --------------------------------------------------------

--
-- Table structure for table `tblsuplier`
--

CREATE TABLE `tblsuplier` (
  `ID` int(11) NOT NULL,
  `SUPLIERID` varchar(90) DEFAULT NULL,
  `FIRSTNAME` varchar(90) DEFAULT NULL,
  `LASTNAME` varchar(90) DEFAULT NULL,
  `ADDRESS` varchar(90) DEFAULT NULL,
  `TELEPHONE` varchar(30) DEFAULT NULL,
  `MOBILE` varchar(30) DEFAULT NULL,
  `TYPE` varchar(90) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblsuplier`
--

INSERT INTO `tblsuplier` (`ID`, `SUPLIERID`, `FIRSTNAME`, `LASTNAME`, `ADDRESS`, `TELEPHONE`, `MOBILE`, `TYPE`) VALUES
(5, '20201223', 'Janry', 'Tano', 'Kab. city', '44-55-5555', '09496585632', 'SUPLIER');

-- --------------------------------------------------------

--
-- Table structure for table `tbltransaction`
--

CREATE TABLE `tbltransaction` (
  `STOCKINID` int(11) NOT NULL,
  `TRANSACTIONNUMBER` varchar(30) DEFAULT NULL,
  `TRANSACTIONDATE` date NOT NULL,
  `TYPE` varchar(30) NOT NULL,
  `SUPLIERCUSTOMERID` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbltransaction`
--

INSERT INTO `tbltransaction` (`STOCKINID`, `TRANSACTIONNUMBER`, `TRANSACTIONDATE`, `TYPE`, `SUPLIERCUSTOMERID`) VALUES
(1, '3230235', '2015-02-24', 'StockIn', '0000000'),
(2, '3230236', '2015-02-24', 'StockIn', '0000000'),
(3, '3230237', '2015-02-24', 'StockIn', '0000000'),
(4, '3230238', '2015-02-24', 'StockIn', '0000000'),
(5, '3230239', '2015-02-24', 'StockIn', '0000000'),
(6, '3230240', '2015-02-24', 'StockIn', '0000000'),
(7, '4908726', '2015-02-24', 'StockOut', '122018'),
(8, '4908726', '2015-02-24', 'Returned', '122018'),
(9, '4908726', '2015-02-25', 'Returned', '122018'),
(10, '4908727', '2015-03-13', 'StockOut', '1220111'),
(11, '4908726', '2015-03-13', 'Returned', '122018'),
(12, '4908728', '2016-05-08', 'StockOut', '122018'),
(13, '3230241', '2016-05-08', 'StockIn', '0000000'),
(14, '3230242', '2016-05-08', 'StockIn', '0000000'),
(15, '3230243', '2016-05-08', 'StockIn', '0000000'),
(16, '4908729', '2016-05-08', 'StockOut', '1220111'),
(17, '4908729', '2016-05-08', 'StockOut', '1220111'),
(18, '4908729', '2016-07-14', 'Returned', '1220111'),
(19, '4908731', '2016-07-23', 'StockOut', '122018'),
(20, '4908732', '2016-08-05', 'StockOut', '1220111'),
(21, '4908733', '2016-08-05', 'StockOut', '1220111'),
(22, '4908734', '2016-08-05', 'StockOut', '1220111'),
(23, '4908735', '2016-08-05', 'StockOut', '122018'),
(24, '0', '2016-08-05', 'StockOut', '122018'),
(25, '3230244', '2016-12-09', 'StockIn', '0000000'),
(26, '4908737', '2016-12-09', 'StockOut', '122018'),
(27, '3230245', '2017-07-31', 'StockIn', '0000000'),
(28, '3230246', '2017-08-01', 'StockIn', '0000000'),
(29, '3230247', '2017-10-16', 'StockIn', '0000000');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `user_id` int(11) NOT NULL,
  `name` varchar(90) DEFAULT NULL,
  `user_name` varchar(90) DEFAULT NULL,
  `pass` varchar(90) DEFAULT NULL,
  `type` varchar(30) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`user_id`, `name`, `user_name`, `pass`, `type`) VALUES
(1, 'Valerie Apostol', 'admin', 'd033e22ae348aeb5660fc2140aec35850c4da997', 'Administrator'),
(531325, 'Maria Reffie Deritsoa', 'staff', '6ccb4b7c39a6e77f76ecfa935a855c6c46ad5611', 'Staff');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`emp_code`),
  ADD UNIQUE KEY `emp_code` (`emp_code`);

--
-- Indexes for table `employee_workinfo`
--
ALTER TABLE `employee_workinfo`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `emp_code_2` (`emp_code`),
  ADD KEY `emp_code` (`emp_code`);

--
-- Indexes for table `other_deduction`
--
ALTER TABLE `other_deduction`
  ADD PRIMARY KEY (`KEY`);

--
-- Indexes for table `payroll`
--
ALTER TABLE `payroll`
  ADD PRIMARY KEY (`KEY`),
  ADD KEY `user_id` (`user_id`),
  ADD KEY `trans_id` (`trans_id`),
  ADD KEY `emp_code` (`emp_code`);

--
-- Indexes for table `tblautonumber`
--
ALTER TABLE `tblautonumber`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tblitems`
--
ALTER TABLE `tblitems`
  ADD PRIMARY KEY (`ITEMID`);

--
-- Indexes for table `tblperson`
--
ALTER TABLE `tblperson`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `CUSID` (`SUPLIERCUSTOMERID`);

--
-- Indexes for table `tblsettings`
--
ALTER TABLE `tblsettings`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tblstock_in_out`
--
ALTER TABLE `tblstock_in_out`
  ADD PRIMARY KEY (`STOCKOUTID`);

--
-- Indexes for table `tblstock_return`
--
ALTER TABLE `tblstock_return`
  ADD PRIMARY KEY (`STOCKRETURNID`);

--
-- Indexes for table `tblsuplier`
--
ALTER TABLE `tblsuplier`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `SUPID` (`SUPLIERID`);

--
-- Indexes for table `tbltransaction`
--
ALTER TABLE `tbltransaction`
  ADD PRIMARY KEY (`STOCKINID`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`user_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `employee_workinfo`
--
ALTER TABLE `employee_workinfo`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- AUTO_INCREMENT for table `other_deduction`
--
ALTER TABLE `other_deduction`
  MODIFY `KEY` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `payroll`
--
ALTER TABLE `payroll`
  MODIFY `KEY` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT for table `tblautonumber`
--
ALTER TABLE `tblautonumber`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `tblperson`
--
ALTER TABLE `tblperson`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `tblsettings`
--
ALTER TABLE `tblsettings`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `tblstock_in_out`
--
ALTER TABLE `tblstock_in_out`
  MODIFY `STOCKOUTID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- AUTO_INCREMENT for table `tblstock_return`
--
ALTER TABLE `tblstock_return`
  MODIFY `STOCKRETURNID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `tblsuplier`
--
ALTER TABLE `tblsuplier`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `tbltransaction`
--
ALTER TABLE `tbltransaction`
  MODIFY `STOCKINID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=531326;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
