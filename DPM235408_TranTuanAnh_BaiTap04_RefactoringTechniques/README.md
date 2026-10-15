<div align="center">

# 🛠️ BÀI TẬP 04: REFACTORING TECHNIQUES (ĐẦY ĐỦ 34 KỸ THUẬT)
### HỆ THỐNG QUẢN LÝ BÁN HÀNG CÔNG TY NÔNG DƯỢC AN GIANG
**TRƯỜNG ĐẠI HỌC AN GIANG — ĐẠI HỌC QUỐC GIA TP. HỒ CHÍ MINH**

---

[![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![.NET](https://img.shields.io/badge/.NET-8.0%20%7C%2010.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![Refactoring.Guru](https://img.shields.io/badge/Refactoring-Refactoring.Guru-FFA500?style=for-the-badge&logo=codewars&logoColor=white)](https://refactoring.guru/refactoring/techniques)
[![Build Status](https://img.shields.io/badge/Build-Passing-brightgreen?style=for-the-badge&logo=github-actions&logoColor=white)](https://github.com/nobianh78/ThietKeBaoTriPhanMem)

<br/>

> *"Tái cấu trúc mã nguồn toàn diện với đầy đủ 34 kỹ thuật Refactoring (Simplifying Conditional Expressions, Simplifying Method Calls, Dealing with Generalization) theo chuẩn Refactoring.Guru và giải quyết triệt để các Code Smell trong hệ thống Nông Dược An Giang."*

</div>

---

## 👤 THÔNG TIN HỌC VIÊN THỰC HIỆN

| 🎯 Thông tin | 📝 Chi tiết |
|:---|:---|
| **Học viên thực hiện** | **NGUYỄN TUẤN ANH** |
| **Mã học viên (MSSV)** | `DPM235407` |
| **Lớp / Khóa** | Cao học Kỹ thuật Phần mềm (K24) |
| **Đơn vị đào tạo** | Trường Đại học An Giang — ĐHQG-HCM |
| **Học phần** | Thiết kế phát triển và Bảo trì Phần mềm |
| **Tài liệu tham khảo lý thuyết** | [Refactoring.Guru - Refactoring Techniques](https://refactoring.guru/refactoring/techniques) |
| **Mã nguồn thực tế tham chiếu** | Dự án gốc `Cuahang_Nongduoc` (`frmBanLe.cs`, `frmBanSi.cs`, `frmSanPham.cs`, `frmSoLuongTon.cs`, `BusinessObject/`) |

---

## 📋 DANH SÁCH ĐẦY ĐỦ 34 KỸ THUẬT REFACTORING BÀI TẬP 04

Mỗi kỹ thuật đều được tổ chức thành thư mục độc lập gồm 3 file:
1. `..._Before.cs`: Mã nguồn trước khi tái cấu trúc chứa Code Smell.
2. `..._After.cs`: Mã nguồn sau khi áp dụng kỹ thuật chuẩn Refactoring.Guru.
3. `..._Real.cs`: Mã nguồn ứng dụng giải quyết bài toán nghiệp vụ Cửa hàng Nông Dược An Giang (`FileDuocThayDua`).

---

### 🌟 NHÓM 1: SIMPLIFYING CONDITIONAL EXPRESSIONS (8 KỸ THUẬT)
> Project: `DPM235408_TranTuanAnh_BaiTap04_01_SimplifyingConditionalExpressions`

| STT | Kỹ thuật Refactoring | Liên kết Refactoring Guru | Thư mục & Ứng dụng thực tế Nông Dược An Giang |
|:---:|:---|:---|:---|
| 1 | [Consolidate Conditional Expression](https://refactoring.guru/consolidate-conditional-expression) | `01_ConsolidateConditionalExpression/` | Gộp các điều kiện cấm lưu hành (hết hạn, bộ cấm, chưa kiểm định) thành hàm kiểm tra hợp lệ xuất kho thuốc BVTV |
| 2 | [Consolidate Duplicate Conditional Fragments](https://refactoring.guru/consolidate-duplicate-conditional-fragments) | `02_ConsolidateDuplicateConditionalFragments/` | Trích xuất thao tác cập nhật thẻ kho và in lệnh xuất hàng ra ngoài phân nhánh Bán sỉ / Bán lẻ |
| 3 | [Decompose Conditional](https://refactoring.guru/decompose-conditional) | `03_DecomposeConditional/` | Tách điều kiện xác định vụ mùa Đông Xuân và phương thức tính giá trợ cấp lúa vụ xuống giống |
| 4 | [Replace Conditional with Polymorphism](https://refactoring.guru/replace-conditional-with-polymorphism) | `04_ReplaceConditionalWithPolymorphism/` | Thay thế switch-case tính chiết khấu bằng đa hình: `DaiLyCap1`, `DaiLyCap2`, `NongDanHopTacXa` |
| 5 | [Remove Control Flag](https://refactoring.guru/remove-control-flag) | `05_RemoveControlFlag/` | Dừng duyệt ngay lập tức khi phát hiện hoạt chất độc hại cấm lưu hành (Paraquat, Chlorpyrifos) trong kho |
| 6 | [Replace Nested Conditional with Guard Clauses](https://refactoring.guru/replace-nested-conditional-with-guard-clauses) | `06_ReplaceNestedConditionalWithGuardClauses/` | Dùng Guard Clauses thẩm định phiếu nhập kho vật tư (NCC, số lượng > 0, HSD > 6 tháng, sức chứa kho) |
| 7 | [Introduce Null Object](https://refactoring.guru/introduce-null-object) | `07_IntroduceNullObject/` | Giới thiệu `KhachHangVangLai_Real` (Null Object) xử lý khách mua lẻ thuốc không đăng ký, tránh NullReferenceException |
| 8 | [Introduce Assertion](https://refactoring.guru/introduce-assertion) | `08_IntroduceAssertion/` | Đưa Assertion kiểm tra số lượng xuất kho không âm, không vượt tồn kho và tỷ lệ chiết khấu $\le 50\%$ |

---

### 🚀 NHÓM 2: SIMPLIFYING METHOD CALLS (14 KỸ THUẬT)
> Project: `DPM235408_TranTuanAnh_BaiTap04_02_SimplifyingMethodCalls`

| STT | Kỹ thuật Refactoring | Liên kết Refactoring Guru | Thư mục & Ứng dụng thực tế Nông Dược An Giang |
|:---:|:---|:---|:---|
| 1 | [Add Parameter](https://refactoring.guru/add-parameter) | `01_AddParameter/` | Bổ sung tham số tỷ lệ thuế VAT và cước xe tải giao ruộng khi tính tổng hóa đơn bán sỉ nông dược |
| 2 | [Remove Parameter](https://refactoring.guru/remove-parameter) | `02_RemoveParameter/` | Loại bỏ tham số dư thừa `maNhanVienCu` trong biên bản tiêu hủy thuốc BVTV hết hạn |
| 3 | [Rename Method](https://refactoring.guru/rename-method) | `03_RenameMethod/` | Đổi tên hàm tối nghĩa `Lay_DL()` thành `LayThongTinDonGiaThuocHienHanh()` theo chuẩn Clean Code |
| 4 | [Separate Query from Modifier](https://refactoring.guru/separate-query-from-modifier) | `04_SeparateQueryFromModifier/` | Tách phương thức kiểm tra tồn kho `KiemTraDuTonKho()` (Query) khỏi thao tác trừ kho `TruSoLuongTonKho()` (Modifier) |
| 5 | [Parameterize Method](https://refactoring.guru/parameterize-method) | `05_ParameterizeMethod/` | Gộp các hàm giảm giá cố định thành hàm `ApDungChinhSachHoTro(tiLeGiam, lyDo)` bình ổn giá thị trường |
| 6 | [Introduce Parameter Object](https://refactoring.guru/introduce-parameter-object) | `06_IntroduceParameterObject/` | Đóng gói cụm tham số dải ngày, địa bàn huyện, nhóm thuốc thành đối tượng `BoLocThongKeDoanhThu_Real` |
| 7 | [Preserve Whole Object](https://refactoring.guru/preserve-whole-object) | `07_PreserveWholeObject/` | Truyền toàn bộ đối tượng `LoThuocBaoVeThucVat_Real` vào thẩm định xuất kho thay vì truyền lẻ tẻ từng trường |
| 8 | [Remove Setting Method](https://refactoring.guru/remove-setting-method) | `08_RemoveSettingMethod/` | Khóa trường `MaPhieu`, `NgayLapPhieu`, `MaNhanVien` bằng readonly để bảo toàn tính pháp lý chứng từ kế toán |
| 9 | [Replace Parameter with Explicit Methods](https://refactoring.guru/replace-parameter-with-explicit-methods) | `09_ReplaceParameterWithExplicitMethods/` | Tách cờ phương tiện vận chuyển thành `DieuXeTaiGiaoPhanBon()`, `DieuShipperXeMay()`, `DieuGheSongCuuLong()` |
| 10 | [Replace Parameter with Method Call](https://refactoring.guru/replace-parameter-with-method-call) | `10_ReplaceParameterWithMethodCall/` | Để hàm `TinhTienThanhToanSauChietKhau()` tự gọi `TinhTienHangGoc()` thay vì bắt caller truyền vào |
| 11 | [Hide Method](https://refactoring.guru/hide-method) | `11_HideMethod/` | Chuyển các hàm hạch toán sổ cái nội bộ sang `private` trong module quản lý công nợ (`frmThanhToan.cs`) |
| 12 | [Replace Constructor with Factory Method](https://refactoring.guru/replace-constructor-with-factory-method) | `12_ReplaceConstructorWithFactoryMethod/` | Static Factory Methods: `TaoGoiDroneCanhDongMauLon()` và `TaoGoiPhunBinhTruyenThong()` |
| 13 | [Replace Error Code with Exception](https://refactoring.guru/replace-error-code-with-exception) | `13_ReplaceErrorCodeWithException/` | Ném `KhongDuTonKhoThuocException`, `ThuocQuaHanSuDungException` thay cho việc trả về mã lỗi -1, -2 |
| 14 | [Replace Exception with Test](https://refactoring.guru/replace-exception-with-test) | `14_ReplaceExceptionWithTest/` | Dùng `TryGetValue` kiểm tra mã vạch trong từ điển giá niêm yết thay vì bắt `KeyNotFoundException` |

---

### 📦 NHÓM 3: DEALING WITH GENERALIZATION (12 KỸ THUẬT)
> Project: `DPM235408_TranTuanAnh_BaiTap04_03_DealingWithGeneralization`

| STT | Kỹ thuật Refactoring | Liên kết Refactoring Guru | Thư mục & Ứng dụng thực tế Nông Dược An Giang |
|:---:|:---|:---|:---|
| 1 | [Pull Up Field](https://refactoring.guru/pull-up-field) | `01_PullUpField/` | Đưa các trường `MaSanPham`, `TenSanPham`, `DonViTinh`, `DonGia` lên lớp cha `VatTuNongNghiep_Real` |
| 2 | [Pull Up Method](https://refactoring.guru/pull-up-method) | `02_PullUpMethod/` | Kéo phương thức in Footer chữ ký 3 bên (Thủ kho, Kế toán, Khách hàng) lên lớp cha `PhieuKhoBase_Real` |
| 3 | [Pull Up Constructor Body](https://refactoring.guru/pull-up-constructor-body) | `03_PullUpConstructorBody/` | Chuyển việc khởi tạo `MaPhieu`, `NgayLap`, `NhanVienLap`, `GhiChu` lên constructor của `ChungTuKhoNongDuoc_Real` |
| 4 | [Push Down Field](https://refactoring.guru/push-down-field) | `04_PushDownField/` | Đẩy trường `ChiSoDocCapTinhLD50` và `VachMauCanhBao` từ lớp cha xuống lớp con `ThuocBaoVeThucVatDocHai_Real` |
| 5 | [Push Down Method](https://refactoring.guru/push-down-method) | `05_PushDownMethod/` | Đẩy phương thức `YeuCauTrangBiBaoHoDacBiet()` xuống riêng lớp thuốc trừ sâu nhóm độc cao |
| 6 | [Extract Subclass](https://refactoring.guru/extract-subclass) | `06_ExtractSubclass/` | Tách lớp con `DaiLyCap1VIP_Real` từ `DaiLyPhanPhoi` để quản lý hạn mức công nợ 500 triệu và kỹ sư túc trực |
| 7 | [Extract Superclass](https://refactoring.guru/extract-superclass) | `07_ExtractSuperclass/` | Trích xuất lớp cha trừu tượng `DoiTacKinhDoanhNongDuoc_Real` từ Khách Hàng Nông Dân và Nhà Cung Cấp Hóa Chất |
| 8 | [Extract Interface](https://refactoring.guru/extract-interface) | `08_ExtractInterface/` | Trích xuất `IKiemDinhChatLuongNongDuoc_Real` cho Module KCS thẩm định chất lượng thuốc BVTV và phân bón |
| 9 | [Collapse Hierarchy](https://refactoring.guru/collapse-hierarchy) | `09_CollapseHierarchy/` | Sáp nhập lớp con vô dụng `ThuocDangBot` vào lớp `ThuocBaoVeThucVat_Real` và phân loại bằng thuộc tính `DangBaoChe` |
| 10 | [Form Template Method](https://refactoring.guru/form-template-method) | `10_FormTemplateMethod/` | Khung 4 bước quy trình `QuyTrinhNhapKhoTemplate_Real`: Tiếp nhận -> Xét nghiệm mẫu -> Kiểm tra kho -> Dán tem QR |
| 11 | [Replace Inheritance with Delegation](https://refactoring.guru/replace-inheritance-with-delegation) | `11_ReplaceInheritanceWithDelegation/` | Thay thế kế thừa `List<LoThuoc>` bằng ủy quyền trong `KhoThuocFEFO_Real` để bảo vệ trật tự xuất kho |
| 12 | [Replace Delegation with Inheritance](https://refactoring.guru/replace-delegation-with-inheritance) | `12_ReplaceDelegationWithInheritance/` | Cho `PhieuBanLeNongDuoc_Real` kế thừa trực tiếp `ChungTuBanHangGoc_Real` thay vì ủy quyền từng phương thức |

---

## 🚀 HƯỚNG DẪN BIÊN DỊCH VÀ CHẠY THỬ NGHIỆM

```powershell
cd C:\Hoc\ThietKeBaoTriPhanMem\DPM235408_TranTuanAnh_BaiTap04_RefactoringTechniques

# 1. Biên dịch toàn bộ Solution Bài Tập 04
dotnet build DPM235408_TranTuanAnh_BaiTap04_RefactoringTechniques.sln

# 2. Chạy Nhóm 1: Simplifying Conditional Expressions (8 kỹ thuật)
dotnet run --project DPM235408_TranTuanAnh_BaiTap04_01_SimplifyingConditionalExpressions

# 3. Chạy Nhóm 2: Simplifying Method Calls (14 kỹ thuật)
dotnet run --project DPM235408_TranTuanAnh_BaiTap04_02_SimplifyingMethodCalls

# 4. Chạy Nhóm 3: Dealing with Generalization (12 kỹ thuật)
dotnet run --project DPM235408_TranTuanAnh_BaiTap04_03_DealingWithGeneralization
```

---

<div align="center">

**© 2026 Nguyễn Tuấn Anh (MSSV: DPM235407) — Trường Đại học An Giang**  
*Mọi ý kiến đóng góp xin vui lòng tạo Issue hoặc Pull Request trên Repository.*

</div>
