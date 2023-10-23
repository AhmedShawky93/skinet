export interface Pagintion<T> {
    pageIndex: number;
    pageSize: number;
    count: number;
    data: T;
}